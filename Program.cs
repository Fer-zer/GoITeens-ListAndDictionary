     //1
        List<int> treasures = new List<int>();
        for (int i = 1; i <= 5; i++)
        {
            treasures.Add(i);
        }
        Console.WriteLine("Збір скарбів: " + string.Join(", ", treasures));

        //2
        List<int> cities = new List<int>();
        int city = 1;
        for (int i = 0; i < 5; i++)
        {
            cities.Add(city);
            city = city * 2; // кожного разу вдвічі більше
        }
        Console.WriteLine("Будівництво міст: " + string.Join(", ", cities));

        //3
        List<int> portals = new List<int>();
        int portal = 1;
        for (int i = 0; i < 5; i++)
        {
            portals.Add(portal);
            portal = portal * 2;
        }
        Console.WriteLine("Магічні портали: " + string.Join(", ", portals));

        //4
        List<int> planets = new List<int>();
        int distance = 100;
        for (int i = 0; i < 5; i++)
        {
            planets.Add(distance);
            distance = distance * 2;
        }
        Console.WriteLine("Подорож на планети: " + string.Join(", ", planets));

        //5
        List<int> islandTreasures = new List<int>();
        int treasure = 1;
        for (int i = 0; i < 5; i++)
        {
            islandTreasures.Add(treasure);
            treasure = treasure + i;
        }
        Console.WriteLine("Скарби на островах: " + string.Join(", ", islandTreasures));

        //6
        List<int> civilization = new List<int> { 1 };
        for (int i = 1; i < 5; i++)
        {
            int sum = 0;
            foreach (int num in civilization)
            {
                sum += num;
            }
            civilization.Add(sum);
        }
        Console.WriteLine("Розвиток цивілізації: " + string.Join(", ", civilization));

        //7.
        List<int> stations = new List<int>();
        int station = 1;
        for (int i = 0; i < 5; i++)
        {
            stations.Add(station);
            station = station * 3;
        }
        Console.WriteLine("Космічні станції: " + string.Join(", ", stations));

        //8
        List<int> crystals = new List<int>();
        int crystal = 1;
        for (int i = 0; i < 5; i++)
        {
            crystals.Add(crystal);
            crystal = crystal + 4;
        }
        Console.WriteLine("Магічні кристали: " + string.Join(", ", crystals));

        //9.
        List<int> years = new List<int>();
        int year = 2025;
        for (int i = 0; i < 5; i++)
        {
            years.Add(year);
            year -= 10;
        }
        Console.WriteLine("Подорож у часі: " + string.Join(", ", years));

        //10
        List<int> artifacts = new List<int> { 1 };
        for (int i = 1; i < 5; i++)
        {
            int sum = 0;
            foreach (int a in artifacts)
            {
                sum += a;
            }
            artifacts.Add(sum);
        }
        Console.WriteLine("Героїчний похід: " + string.Join(", ", artifacts));


double average = (double)total / marks.Count;
Console.WriteLine("📊 Середня оцінка у класі: " + average.ToString("F1"));

