// See https://aka.ms/new-console-template for more information
using AdapterPattern.Core;
using System.Text;
using System.Text.Json;

Console.WriteLine("Hello, World!");
var payrollControllerUrl = "https://localhost:7232/api/PayrollCalculator";
var reader = new EmployeeDataReder();
var employees=reader.GetEmployees();
var client = new HttpClient();
foreach(var employee in employees)
{
    var request = new HttpRequestMessage(HttpMethod.Post, payrollControllerUrl);
    var employeeAdepter = new PayrollSystemEmployeeAdapter(employee);
    request.Content = new StringContent(JsonSerializer.Serialize(employeeAdepter), Encoding.UTF8, "application/json");
    var respone = await client.SendAsync(request);
    var responeJson = await respone.Content.ReadAsStringAsync();
    var salary = decimal.Parse(responeJson);
        Console.WriteLine($"salary for `{employee.FullName}` as of today = `{salary}`");
}
Console.ReadKey();