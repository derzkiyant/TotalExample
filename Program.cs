
Console.WriteLine("\nЗадача: Написать программу, которая из имеющегося массива строк формирует массив из строк, " +
                    "длина которых меньше либо равна 3 символа. Первоначальный массив можно ввести с клавиатуры, " +
                    "либо задать на старте выполнения алгоритма. При решении не рекомендуется пользоваться " +
                    "коллекциями, лучше обойтись исключительно массивами.\nПримеры:" +
                    "\n['hello', '2', 'world', ':)'] -> ['2', ':)']" +
                    "\n['1234', '1567', '-2', 'computer science'] -> ['-2']\n['Russia', 'Denmark', 'Kazan'] -> []" +
                    "\n\nРешение:");


string[] array = { "hello", "2", "world", ":)" };
Console.WriteLine($"Начальный массив: [{string.Join(", ", array)}]");

int limit = 4;

List<string> dinArray = new List<string>();

for (int i = 0; i < array.Length; i++)
    if (array[i].Length < limit) dinArray.Add(array[i]);

Console.WriteLine($"Итоговый массив: [{string.Join(", ", dinArray)}]");
