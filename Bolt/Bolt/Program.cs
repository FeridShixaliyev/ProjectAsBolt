using System;

namespace Bolt
{
    class Program
    {
        static void Main(string[] args)
        {
            Bus bus1 = new Bus("Mercedes", "Splinter", 30, 800, "Qasim Aliyev");
            Bus bus2 = new Bus("Daewoo", "A5500", 22, 600,"Kazim Veliyev");
            Bus bus3 = new Bus("Volvo", "Getta 300", 28, 700, "Orxan Turalov");

            Minivan minivan1 = new Minivan("Mercedes", "Vito", 12, 500, "Huseyn Dadashov");
            Minivan minivan2 = new Minivan("Kia", "Capella", 10, 450, "Ilkin Aliyev");
            Minivan minivan3 = new Minivan("Volkswagen", "Multivan", 12, 500, "Fazil Quliyev");

            Car car1 = new Car("Volvo", "X90", 7, 350, "Allahver Resulov");
            Car car2 = new Car("Toyota", "Prius", 5, 150, "Tural Hesenli");
            Car car3 = new Car("Hyundai", "Elentra", 5, 200, "Seid Muradov");

            User user2 = new User("ferid_323", "fero11111");
            User user3 = new User("_8asad", "huseyn12678");
            User user4 = new User("code_academy", "code0000");

            Admin admin = new Admin("ferid_1", "Ferid123");
            admin.AddUser(user2);
            admin.AddUser(user3);
            admin.AddUser(user4);

            Garage garage = new Garage("Garage");
            garage.AddBus(bus1);
            garage.AddBus(bus2);
            garage.AddBus(bus3);
            garage.AddVan(minivan1);
            garage.AddVan(minivan2);
            garage.AddVan(minivan3);
            garage.AddCar(car1);
            garage.AddCar(car2);
            garage.AddCar(car3);


            Console.WriteLine("Adinizi daxil edin:");
            string name = Console.ReadLine();
            Console.WriteLine($"\nXos gelmisen {name}");
            Console.WriteLine("\nEger adminsense Admin datalari daxil edib admin panele daxil ola bilersen,eger Admin deyilseniz 'n'(not)- a clikleyin(DIQQET!!! EGER ADMIN DEYILSENIZ SISTEM SIZI PROQRAMDAN ATACAQ!!!!)");
            Console.WriteLine("Admin olaraq daxil olmaq istiyirsiz?\n( y / n )");
            char choice;
            do
            {
                choice = Convert.ToChar(Console.ReadLine());
            } while (choice != 'y' && choice != 'n');

            if (choice == 'y')
            {
                Console.WriteLine("Admin olaraq daxil olmaq ucun sifreni daxil edin:");
                string password = Console.ReadLine();
                if (password == admin.Password)
                {
                    Console.WriteLine("\nAdmin panele xosh gelmisen:))\n");
                    bool ap = false;
                    do
                    {
                        Console.WriteLine("\n>>>>>>>Esas Menyu<<<<<<<\n");
                        Console.WriteLine("1. Neqliyyat vasitelerini goster");
                        Console.WriteLine("2. Id vasitesi ile neqliyyat vasitesi sil");
                        Console.WriteLine("3. Id vasitesi ile edit emeliyyatlari");
                        Console.WriteLine("4. Userleri gor");
                        Console.WriteLine("0. Proqramdan cixis");
                        string option = Console.ReadLine();
                        switch (option)
                        {
                            case "1":
                                bool case1 = true;
                                do
                                {
                                    Console.WriteLine("1. Aftobuslari goster");
                                    Console.WriteLine("2. Minivanlari goster");
                                    Console.WriteLine("3. Minik avtomobillerini goster");
                                    Console.WriteLine("4. Butun neqliyyat vasitelerini goster");
                                    Console.WriteLine("0. Geri");
                                    string casesw = Console.ReadLine();
                                    switch (casesw)
                                    {
                                        case "1":
                                            garage.GetBus();
                                            break;
                                        case "2":
                                            garage.GetVan();
                                            break;
                                        case "3":
                                            garage.GetCar();
                                            break;
                                        case "4":
                                            garage.AGetAllVehicle();
                                            break;
                                        case "0":
                                            case1 = false;
                                            break;
                                        default:
                                            Console.WriteLine("Duzgun secim edin!!");
                                            break;
                                    }
                                } while (case1);
                                break;
                            case "2":
                                bool case2 = true;
                                do
                                {
                                    Console.WriteLine("1. Aftobuslari sil");
                                    Console.WriteLine("2. Minivanlari sil");
                                    Console.WriteLine("3. Minik avtomobillerini sil");
                                    Console.WriteLine("0. Geri");
                                    string casesw = Console.ReadLine();
                                    switch (casesw)
                                    {
                                        case "1":
                                            Console.WriteLine("Silmek istediyin aftobusun Id-sini daxil et");
                                            int busId = Convert.ToInt32(Console.ReadLine());
                                            garage.RemoveBusById(busId);
                                            break;
                                        case "2":
                                            Console.WriteLine("Silmek istediyin minivanin Id-sini daxil et");
                                            int miniId = Convert.ToInt32(Console.ReadLine());
                                            garage.RemoveVanById(miniId);
                                            break;
                                        case "3":
                                            Console.WriteLine("Silmek istediyin minik avtomobilin Id-sini daxil et");
                                            int carId = Convert.ToInt32(Console.ReadLine());
                                            garage.RemoveCarById(carId);
                                            break;
                                        case "0":
                                            case2 = false;
                                            break;
                                        default:
                                            Console.WriteLine("Duzgun secim edin!!");
                                            break;
                                    }
                                } while (case2);
                                break;
                            case "3":
                                Console.WriteLine("------Edit Menyu------");
                                bool case3 = true;
                                do
                                {
                                    Console.WriteLine("1. Aftobusu editle");
                                    Console.WriteLine("2. Minivani editle");
                                    Console.WriteLine("3. Minik avtomobilini editle");
                                    Console.WriteLine("0. Geri");
                                    string opti = Console.ReadLine();
                                    switch (opti)
                                    {
                                        case "1":
                                            Console.WriteLine("Aftobusun editlemek istediyiniz elementini secin:");
                                            bool editbus = false;
                                            do
                                            {
                                                Console.WriteLine("1. Brandini deyis");
                                                Console.WriteLine("2. Modelini deyis");
                                                Console.WriteLine("3. Surucusunu deyis");
                                                Console.WriteLine("0. Geri");
                                                string busedit = Console.ReadLine();
                                                switch (busedit)
                                                {
                                                    case "1":
                                                        Console.WriteLine("Deyismek istediyiniz aftobusun Id-sini daxil edin");
                                                        int busId = Convert.ToInt32(Console.ReadLine());
                                                        Console.WriteLine("Yeni Brand-i daxil edin:");
                                                        string newBrand = Console.ReadLine();
                                                        garage.EditBusBrand(busId, newBrand);
                                                        break;
                                                    case "2":
                                                        Console.WriteLine("Deyismek istediyiniz aftobusun Id-sini daxil edin");
                                                        int busId1 = Convert.ToInt32(Console.ReadLine());
                                                        Console.WriteLine("Yeni Modeli-i daxil edin:");
                                                        string newModel = Console.ReadLine();
                                                        garage.EditBusModel(busId1, newModel);
                                                        break;
                                                    case "3":
                                                        Console.WriteLine("Deyismek istediyiniz aftobusun Id-sini daxil edin");
                                                        int busId2 = Convert.ToInt32(Console.ReadLine());
                                                        Console.WriteLine("Yeni Surucunu daxil edin:");
                                                        string newDriver = Console.ReadLine();
                                                        garage.EditBusDriver(busId2, newDriver);
                                                        break;
                                                    case "0":
                                                        editbus = true;
                                                        break;
                                                    default:
                                                        Console.WriteLine("Duzgun secim edin!!");
                                                        break;
                                                }
                                            } while (!editbus);
                                            break;
                                        case "2":
                                            Console.WriteLine("Minivanin editlemek istediyiniz elementini secin:");
                                            bool editvan = false;
                                            do
                                            {
                                                Console.WriteLine("1. Brandini deyis");
                                                Console.WriteLine("2. Modelini deyis");
                                                Console.WriteLine("3. Surucusunu deyis");
                                                Console.WriteLine("0. Geri");
                                                string busedit = Console.ReadLine();
                                                switch (busedit)
                                                {
                                                    case "1":
                                                        Console.WriteLine("Deyismek istediyiniz minivanin Id-sini daxil edin");
                                                        int busId = Convert.ToInt32(Console.ReadLine());
                                                        Console.WriteLine("Yeni Brand-i daxil edin:");
                                                        string newBrand = Console.ReadLine();
                                                        garage.EditVanBrand(busId, newBrand);
                                                        break;
                                                    case "2":
                                                        Console.WriteLine("Deyismek istediyiniz minivanin Id-sini daxil edin");
                                                        int busId1 = Convert.ToInt32(Console.ReadLine());
                                                        Console.WriteLine("Yeni Modeli-i daxil edin:");
                                                        string newModel = Console.ReadLine();
                                                        garage.EditVanModel(busId1, newModel);
                                                        break;
                                                    case "3":
                                                        Console.WriteLine("Deyismek istediyiniz minivanin Id-sini daxil edin");
                                                        int busId2 = Convert.ToInt32(Console.ReadLine());
                                                        Console.WriteLine("Yeni Surucunu daxil edin:");
                                                        string newDriver = Console.ReadLine();
                                                        garage.EditVanDriver(busId2, newDriver);
                                                        break;
                                                    case "0":
                                                        editvan = true;
                                                        break;
                                                    default:
                                                        Console.WriteLine("Duzgun secim edin!!");
                                                        break;
                                                }
                                            } while (!editvan);
                                            break;
                                        case "3":
                                            Console.WriteLine("Minik avtomobilinin editlemek istediyiniz elementini secin:");
                                            bool editcar = false;
                                            do
                                            {
                                                Console.WriteLine("1. Brandini deyis");
                                                Console.WriteLine("2. Modelini deyis");
                                                Console.WriteLine("3. Surucusunu deyis");
                                                Console.WriteLine("0. Geri");
                                                string busedit = Console.ReadLine();
                                                switch (busedit)
                                                {
                                                    case "1":
                                                        Console.WriteLine("Deyismek istediyiniz avtomobilin Id-sini daxil edin");
                                                        int busId = Convert.ToInt32(Console.ReadLine());
                                                        Console.WriteLine("Yeni Brand-i daxil edin:");
                                                        string newBrand = Console.ReadLine();
                                                        garage.EditCarBrand(busId, newBrand);
                                                        break;
                                                    case "2":
                                                        Console.WriteLine("Deyismek istediyiniz avtomobilin Id-sini daxil edin");
                                                        int busId1 = Convert.ToInt32(Console.ReadLine());
                                                        Console.WriteLine("Yeni Modeli-i daxil edin:");
                                                        string newModel = Console.ReadLine();
                                                        garage.EditCarModel(busId1, newModel);
                                                        break;
                                                    case "3":
                                                        Console.WriteLine("Deyismek istediyiniz avtomobilin Id-sini daxil edin");
                                                        int busId2 = Convert.ToInt32(Console.ReadLine());
                                                        Console.WriteLine("Yeni Surucunu daxil edin:");
                                                        string newDriver = Console.ReadLine();
                                                        garage.EditCarDriver(busId2, newDriver);
                                                        break;
                                                    case "0":
                                                        editcar = true;
                                                        break;
                                                    default:
                                                        Console.WriteLine("Duzgun secim edin!!");
                                                        break;
                                                }
                                            } while (!editcar);
                                            break;
                                        case "0":
                                            case3 = false;
                                            break;
                                        default:
                                            Console.WriteLine("Duzgun secim edin!!");
                                            break;
                                    }
                                } while (case3);

                                break;
                            case "4":
                                Console.WriteLine("\nUserler siyahisi:");
                                foreach (var item in admin.GetUserList())
                                {
                                    Console.WriteLine(item.ShowInfo());
                                }
                                break;
                            case "0":
                                ap = true;
                                break;
                            default:
                                Console.WriteLine("Duzgun secim edin!!");
                                break;
                        }
                    } while (!ap);
                }
                else
                    Console.WriteLine($"{name}, Siz admin olmadiginiz ucun sistemden uzaqlasdirildiniz");
            }
            else if (choice == 'n')
            {
                Console.WriteLine($"{name},Xos gelmisiz,\n siz 'User' olaraq davam edirsiz");
                //Console.WriteLine("\nZehmet olamasa nece nefer oldugunuz qeyd edin");
                //int count = Convert.ToInt32(Console.ReadLine());
                bool user = true;
                do
                {
                    Console.WriteLine("\n>>>>> Menu <<<<<");
                    Console.WriteLine("1. Taksi sifarisi");
                    Console.WriteLine("2. Minivan sifarisi");
                    Console.WriteLine("3. Aftobus sifarisi");
                    Console.WriteLine("4. Isteyinize gore filterleyin");
                    Console.WriteLine("5. Qeydiyyatdan kec");
                    Console.WriteLine("0. Proqramdan cix");
                    string userstr = Console.ReadLine();
                    switch (userstr)
                    {
                        case "1":
                            garage.GetCar();
                            Console.WriteLine("Hansi Taksini sifaris vermey istiyirsinizse brandini daxil edin");
                            string carbrand = Console.ReadLine();
                            if (garage.TakeCars().Exists(x => x.Brand == carbrand))
                            {
                                Console.WriteLine("Asagidaki taksi ugurla sifaris olundu");
                                Console.WriteLine(garage.FilterByCar(carbrand).ShowInfo()) ;
                            }
                            else
                                Console.WriteLine("\nBele bir adda brand yoxdur!!");
                            break;
                        case "2":
                            garage.GetVan();
                            Console.WriteLine("Hansi Minivan-i sifaris vermey istiyirsinizse brandini daxil edin");
                            string vanbrand = Console.ReadLine();
                            if (garage.TakeVans().Exists(x => x.Brand == vanbrand))
                            {
                                Console.WriteLine("Asagidaki taksi ugurla sifaris olundu");
                                Console.WriteLine(garage.FilterByMinivan(vanbrand).ShowInfo());
                            }
                            else
                                Console.WriteLine("\nBele bir adda brand yoxdur!!");
                            break;
                        case "3":
                            garage.GetBus();
                            Console.WriteLine("Hansi aftobusu-i sifaris vermey istiyirsinizse brandini daxil edin");
                            string busbrand = Console.ReadLine();
                            if (garage.TakeBus().Exists(x => x.Brand == busbrand))
                            {
                                Console.WriteLine("Asagidaki taksi ugurla sifaris olundu");
                                Console.WriteLine(garage.FilterByBus(busbrand).ShowInfo());
                            }
                            else
                                Console.WriteLine("\nBele bir adda brand yoxdur!!");
                            break;
                        case "4":
                            Console.WriteLine("Filterlemey istediyiniz neqliyyat vastisini secin");
                            bool filter = true;
                            do
                            {
                                Console.WriteLine("1. Taksi filterle");
                                Console.WriteLine("2. Minivan filterle");
                                Console.WriteLine("3. Aftobus filterle");
                                Console.WriteLine("0. Geri");

                                string filterStr = Console.ReadLine();
                                switch (filterStr)
                                {
                                    case "1":
                                        Console.WriteLine("En az nece nefer ola bileceyinizi secin");
                                        int min = Convert.ToInt32(Console.ReadLine());
                                        Console.WriteLine("En cox nece nefer ola bileceyinizi secin");
                                        int max= Convert.ToInt32(Console.ReadLine());
                                        Console.WriteLine("Yukunuzun hecmini daxil edin");
                                        int baggage = Convert.ToInt32(Console.ReadLine());
                                        foreach (var item in garage.FilterByCar(min, max, baggage))
                                        {
                                            Console.WriteLine(item.ShowInfo());
                                        }
                                        Console.WriteLine("Hansi Taksini sifaris vermey istiyirsinizse brandini daxil edin");
                                        string carbrandf = Console.ReadLine();
                                        if (garage.TakeCars().Exists(x => x.Brand == carbrandf))
                                        {
                                            Console.WriteLine("Asagidaki taksi ugurla sifaris olundu");
                                            Console.WriteLine(garage.FilterByCar(carbrandf).ShowInfo());
                                        }
                                        else
                                            Console.WriteLine("\nBele bir adda brand yoxdur!!");
                                        break;
                                    case "2":
                                        Console.WriteLine("En az nece nefer ola bileceyinizi secin");
                                        int minM = Convert.ToInt32(Console.ReadLine());
                                        Console.WriteLine("En cox nece nefer ola bileceyinizi secin");
                                        int maxM = Convert.ToInt32(Console.ReadLine());
                                        Console.WriteLine("Yukunuzun hecmini daxil edin");
                                        int baggageM = Convert.ToInt32(Console.ReadLine());
                                        foreach (var item in garage.FilterByMinivan(minM, maxM, baggageM))
                                        {
                                            Console.WriteLine(item.ShowInfo());
                                        }
                                        Console.WriteLine("Hansi Minivan-i sifaris vermey istiyirsinizse brandini daxil edin");
                                        string miniVanbrand = Console.ReadLine();
                                        if (garage.TakeVans().Exists(x => x.Brand == miniVanbrand))
                                        {
                                            Console.WriteLine("Asagidaki taksi ugurla sifaris olundu");
                                            Console.WriteLine(garage.FilterByMinivan(miniVanbrand).ShowInfo());
                                        }
                                        else
                                            Console.WriteLine("\nBele bir adda brand yoxdur!!");
                                        break;
                                    case "3":
                                        Console.WriteLine("En az nece nefer ola bileceyinizi secin");
                                        int minB = Convert.ToInt32(Console.ReadLine());
                                        Console.WriteLine("En cox nece nefer ola bileceyinizi secin");
                                        int maxB = Convert.ToInt32(Console.ReadLine());
                                        Console.WriteLine("Yukunuzun hecmini daxil edin");
                                        int baggageB = Convert.ToInt32(Console.ReadLine());
                                        foreach (var item in garage.FilterByMinivan(minB, maxB, baggageB))
                                        {
                                            Console.WriteLine(item.ShowInfo());
                                        }
                                        Console.WriteLine("Hansi aftobusu-i sifaris vermey istiyirsinizse brandini daxil edin");
                                        string busbrandB = Console.ReadLine();
                                        if (garage.TakeBus().Exists(x => x.Brand == busbrandB))
                                        {
                                            Console.WriteLine("Asagidaki taksi ugurla sifaris olundu");
                                            Console.WriteLine(garage.FilterByBus(busbrandB).ShowInfo());
                                        }
                                        else
                                            Console.WriteLine("\nBele bir adda brand yoxdur!!");
                                        break;
                                    case "0":
                                        filter = false;
                                        break;
                                    default:
                                        Console.WriteLine("Duzgun secim edin!!");
                                        break;
                                }
                            } while (filter);
                            break;
                        case "5":
                            Console.WriteLine("\nIlk olaraq istifadeci adinizi mueyyen edin:");
                            string nickname = Console.ReadLine();
                            Console.WriteLine("\nSonraki addimda sifreni mueyyen edin:");
                            string password = Console.ReadLine();
                            User user1 = new User(nickname, password);
                            admin.AddUser(user1);
                            Console.WriteLine("\nQeydiyyat tamamlandi");
                            break;
                        case "0":
                            user = false;
                            break;
                        default:
                            Console.WriteLine("Zehmet olmasa duzgun secim edin!!");
                            break;
                    }
                } while (user);
                
            }

        }
    }
}
