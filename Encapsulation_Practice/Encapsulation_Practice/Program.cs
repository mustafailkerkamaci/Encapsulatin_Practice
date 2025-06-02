
using Encapsulation_Practice;

Car car1 = new Car("Toyota", "Corolla", "Red", 4);

car1.ShowInfo();

Car car2 = new Car("Honda", "Civic", "Blue", 2);
car2.ShowInfo();

Car car3 = new Car("Ford", "Mustang", "Black", 3); // Bu durumda uyarı mesajı alacağız.
car3.ShowInfo(); // Bu durumda kapi sayisi -1 olarak ayarlanacak ve uyarı mesajı verilecek.

//valoran bir arabinin kapi sayisini degistirmeye calistigimiza ise metota tanimladigimiz hata mesaji  gosterecek.

car1.Doors = 3;
car1.ShowInfo(); // Bu durumda kapi sayisi -1 olarak ayarlanacak ve uyarı mesajı verilecek.