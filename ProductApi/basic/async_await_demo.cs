// class Program {
//     // nhớ là nếu để void sẽ bị lỗi
//     async static Task Main(string[] args){
//         Console.WriteLine("Bắt đầu tải dữ liệu...");

//         string data = await taskDelay();

//         Console.WriteLine("Dữ liệu đã tải: " + data);
//     }
//     // Task kiểu như 1 lời hứa trong c# =  Future


    

//     static async Task<string> taskDelay(){
//         await Task.Delay(3000);
//         return "Data result";
//     }
// }