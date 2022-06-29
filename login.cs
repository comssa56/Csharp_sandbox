using System.Net;
using System.Text.Encodings.Web;
using System.Text.Json;
using System.Text.Unicode;


string csrf_token = "";
string cookie = "";

//Django login
using (var client = new HttpClient())
{
    const string LOGIN_URL = @"http://127.0.0.1:8000/admin/login";
    var request = new HttpRequestMessage(HttpMethod.Get, LOGIN_URL);
//    request.Headers.Add(@"X-Hoge", @"foo");

    var response = await client.SendAsync(request);
    if (response.StatusCode != System.Net.HttpStatusCode.OK)
    {
        Console.WriteLine("Error: Cannot open login page");
        return;
    }

    cookie = response.Headers.GetValues("Set-Cookie").ToArray().Aggregate((x, y) => x + y);
    string csrf = cookie.Split(";")[0];
    csrf_token = csrf.Split("=")[1];
}



using (var client = new HttpClient())
{
    const string LOGIN_URL = @"http://127.0.0.1:8000/admin/login/?next=/admin/";
    var parameters = new Dictionary<string, string>()
    {
        { "csrfmiddlewaretoken", csrf_token },
        { "username", "root" },
        { "password", "root" },
        { "next", "/admin/"}
    };
    var content = new FormUrlEncodedContent(parameters);
    content.Headers.Add("Cookie", cookie);

    var response = await client.PostAsync(new Uri(LOGIN_URL), content);

    if (response.StatusCode != System.Net.HttpStatusCode.OK)
    {
        Console.WriteLine("Error: Cannot login");
        return;
    }
}

using (var client = new HttpClient())
{
    const string LOGIN_URL = @"http://127.0.0.1:8000/admin/memo/memo/";
    var request = new HttpRequestMessage(HttpMethod.Get, LOGIN_URL);
    request.Headers.Add("Cookie", cookie);

    var response = await client.SendAsync(request);

    Console.WriteLine(response.ToString());

}


Console.WriteLine("続行するには何かキーを押してください . . .");
Console.ReadKey();
