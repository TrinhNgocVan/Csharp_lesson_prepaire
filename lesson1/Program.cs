var builder = WebApplication.CreateBuilder(args);
// Khởi tạo một WebApplicationBuilder – dùng để cấu hình ứng dụng, thêm các dịch vụ, và chuẩn bị chạy server.



// Add services to the container.
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
// Cho phép hệ thống ghi nhận các endpoint (API route) để phục vụ việc sinh tài liệu OpenAPI

builder.Services.AddSwaggerGen();
// Tạo tài liệu Swagger (giao diện web giúp test API dễ dàng)

var app = builder.Build();
//Tạo ra một instance WebApplication từ builder để cấu hình middleware và routing.


// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}
/*
Nếu đang chạy trong môi trường phát triển (Development), thì:

UseSwagger() để bật sinh file Swagger JSON.

UseSwaggerUI() để bật giao diện Swagger UI (web) cho việc test API.
http://localhost:5203/swagger/index.html
*/


app.UseHttpsRedirection();
//  Tự động chuyển hướng từ HTTP sang HTTPS.


app.MapGet("/test1",  () =>
{
    return "test-string";
})
.WithName("Demo232132131")
.WithOpenApi()
;


app.Run();



// var summaries = new[]
// {
//     "Freezing", "Bracing", "Chilly", "Cool", "Mild", "Warm", "Balmy", "Hot", "Sweltering", "Scorching"
// };

// app.MapGet("/weatherforecast", () =>
// {
//     var forecast =  Enumerable.Range(1, 5).Select(index =>
//         new WeatherForecast
//         (
//             DateOnly.FromDateTime(DateTime.Now.AddDays(index)),
//             Random.Shared.Next(-20, 55),
//             summaries[Random.Shared.Next(summaries.Length)]
//         ))
//         .ToArray();
//     return forecast;
// })
// .WithName("GetWeatherForecast")
// .WithOpenApi();
// record WeatherForecast(DateOnly Date, int TemperatureC, string? Summary)
// {
//     public int TemperatureF => 32 + (int)(TemperatureC / 0.5556);
// }
