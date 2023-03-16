// 4. Напишите программу, которая будет создавать
	//    копию заданного массива с помощью поэлементного копирования.
	
	int[,] FillMass(int rows, int columns, int start, int end)
	{
	    int[,] Array = new int[rows, columns];
	    for (int i = 0; i < rows; i++)
	    {
	        for (int j = 0; j < columns; j++)
	        {
	            Array[i, j] = new Random().Next(start, end);
	        }
	    }
	    return Array;
	}
	
	void PrinOff(int[,]arr){
	    for (int i = 0; i < arr.GetLength(0); i++){
	        for (int j = 0; j < arr.GetLength(1); j++)
	        {
	            Console.Write($"  {arr[i, j]} ");
	        }
	        Console.WriteLine();
	    }
	}

    int[,]CopyMass(int[,]arr){
	    int row = arr.GetLength(0);
	    int columns = arr.GetLength(1);
	    int[,]newArr = new int[row, columns];
	    for (int i = 0; i < row; i++){
	        for (int j = 0; j < columns; j++)
	        {
	            newArr[i, j] = arr[i, j];
	        }
	      
	    }
	    return newArr;
	}
	
	int[,]mass = FillMass(4, 5, 10, 50);
	PrinOff(mass);
	Console.WriteLine();
	int[,]mass2 = CopyMass(mass);
	PrinOff(mass2);