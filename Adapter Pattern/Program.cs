using Adapter_Pattern.Core;
using System.Text;
using System.Text.Json;

string url = "https://localhost:7255/api/PayrollCalculator";
var reader = new EmployeeDataReader();
var employees=reader.GetEmployees();

var client=new HttpClient();
foreach (var employee in employees)
{
    var request = new HttpRequestMessage(HttpMethod.Post, url);
    var employeeAdapter = new PayrollSystemEmployeeAdapter(employee);
    request.Content = new StringContent(JsonSerializer.Serialize(employeeAdapter), Encoding.UTF8, "application/json");

    var response=await client.SendAsync(request);
    var responseJson=await response.Content.ReadAsStringAsync();
    var salary=decimal.Parse(responseJson);

    Console.WriteLine($"Salary for employee {employee.FullName} as of today = {salary}");
}
Console.ReadLine();