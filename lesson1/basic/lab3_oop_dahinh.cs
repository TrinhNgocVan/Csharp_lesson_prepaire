// class Animal1 {
//     /* virtual : Dùng trong lớp cha để cho phép lớp con ghi đè phương thức đó.
//         Nếu không có virtual, lớp con không thể override được.
//     */
//     public virtual void MakeSound() {
//         Console.WriteLine("Animal makes sound");
//     }
// }

// class Cat : Animal1 {
//     public override void MakeSound() {
//         Console.WriteLine("Meow");
//     }
// }