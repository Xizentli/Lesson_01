﻿/*Дан массив, необходимо найсти в нем элемент, равный тому, который введет пользователь*/

//             0   1   2   3   4   5  6   7
int[] array = {13, 9, 37, 42, 6, 72, 8, 9};

int n = array.Length;
int find = 9; 

int index = 0;

while (index < n)
{
    if(array[index] == find)
    {
        Console.WriteLine(index); //если в массиве будет несколько одинаковых элементов, то алгоритм покажет их все
        break; //прерывание, в этом случае алгоритм прервется, как только найдет первый совпадающий элемент
    }

    //index = index + 1;
    index++;
}