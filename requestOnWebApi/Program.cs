
using System.Text.Json;

string getRequest = "https://localhost:7203/student";

HttpClient request = new HttpClient();

var response = await request.GetAsync(getRequest);

var json = response.Content.ReadAsStringAsync().Result;

Console.WriteLine(json);

