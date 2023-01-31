Написать программу, которая из имеющегося массива строк формирует массив из строк, длина которых меньше либо равна 3 символа. Первоначальный массив можно ввести с клавиатуры, либо задать на старте выполнения алгоритма. При решение не рекомендуется пользоваться коллекциями, лучше обойтись исключительно массивами.
## ***Алгоритм решения*** ##
1. *Вначале объявляем массив строк и заполняем его.*
2. *создаём метод заполнения второго - итогового массива на основе содержимого первого массива согласно условиям задачи. Объявляем второй массив  string[] array2 = new string[array1.Length], указав его размер, соответствующий параметрам нашего первого массива.*
3. *Объявляем переменную count, которая в последующем цикле for при проверке на соответствие нашим условиям (строки, длиной <= 3 символам), будет накапливать эти строки.*
4. *Создаём второй метод VOID для вывода полученного массива.