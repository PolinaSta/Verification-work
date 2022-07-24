// Написать программу, которая из имеющегося массива строк формирует массив из строк, 
// длина которых меньше либо равна трём символам. Первоначальный массив можно ввести с клавиатуры, 
// либо задать на старте выполнения алгоритма. При решении не рекомендуется пользоваться коллекциями, 
// лучше обойтись исключительно массивами.

string[] arrayOne =  {"Be", "future", "or", "no"};
int countOne = MeaningLessThreeSimb(arrayOne);
string[] resultOne =  ResultArray(arrayOne,countOne);

string[] arrayTwo = {"big", "future", "car", "wonderful"};
int countTwo  = MeaningLessThreeSimb(arrayTwo);
string[] resultTwo = ResultArray(arrayTwo,countTwo);

string[] arrayThree = {"mother", "we", "new", "day"};
int countThree = MeaningLessThreeSimb(arrayThree);
string[] resultThree = ResultArray(arrayThree, countThree);

string[] arrayFour = {"up", "one", "51468746", "owl"};
int countFour = MeaningLessThreeSimb(arrayFour);
string[] resultFour = ResultArray(arrayFour, countFour);

void PrintArray(string[] array) 
    {

        for (int i = 0; i < array.Length; i++)
            {
                if (i != array.Length - 1) Console.Write($"{array[i]}, ");
                else Console.Write($"{array[i]}.");
            }
        Console.WriteLine();
    }

int MeaningLessThreeSimb(string[] array)
    {
        int count = 0;
        for (int i = 0; i < array.Length; i++)
            {
                if (array[i].Length <= 3) count++;
            }
        return count;
    }

string[] ResultArray(string[] array, int count)
    {
        string[] result = new string[count];
        for (int i = 0; i < array.Length; i++)
            {
                if (array[i].Length <= 3)
                    {
                        result[result.Length - count] = array[i];
                        count--;
                    }
            }
        return result;
    }

PrintArray(resultOne);
PrintArray(resultTwo);
PrintArray(resultThree);
PrintArray(resultFour);