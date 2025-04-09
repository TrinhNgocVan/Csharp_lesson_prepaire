

// /*
// Tính đóng gói cơ bản 
// private	Chỉ dùng bên trong class
// public	Dùng mọi nơi
// protected	Dùng trong class và class con
// internal	Dùng trong cùng một project/assembly
// protected internal	Kết hợp của protected và internal
// private protected	Chỉ cho phép class con trong cùng assembly
// // */
// public class Student {
//     private string name;

//     protected int stage;

//     protected int Stage{
//         get {return stage;}
//         set {
//             if (value  <= 10){
//                 stage  = value;
//             }
//         }
//     } 


//     public string Name {
//         get { return name;}
//         set {
//             if(!string.IsNullOrEmpty(value)){
//                 name  = value;
//             }
//         }
        
//     }
// }


// public class UniversityStudent : Student{

//     // public void printName(){
//     //     System.Console.WriteLine(name);
//     // }

//     public void printStage(){
//         System.Console.WriteLine(stage);
//     }

//     public static void Main (string[] args){
//         UniversityStudent us1 = new UniversityStudent{ Name = " Demo" , stage = 1};
        

//     }

// }


