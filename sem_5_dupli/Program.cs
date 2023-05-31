
string InputMass()
{
    Console.Write("задайте массив вещественных чисел:  ");
    string mass = Console.ReadLine();
    return mass;
    Console.WriteLine();
}

void CreateArray(string[] mass1,double[] mass2)
{
    for(int i=0; i<mass1.Length; i++)
    {   mass2[i] = Double.Parse(mass1[i]);    
        //Console.Write($"{mass2[i]} ");
    }
    Console.WriteLine();
}
void PrintArray (double [] arr)
{
    for (int i = 0; i < arr.Length; i++)
        { Console.Write(arr[i]+" ");}
    Console.WriteLine();
}


  void ExcludeDuplicate(double []arr)
{          
   int count = 0;  
   int size=arr.Length;      
//double[]arr2= new double[size];
      for (int i = 0; i < arr.Length; i++) 
    {
        bool dup=false;
        for (int j = i+1; j < arr.Length; j++)
        {
        if (arr[i]==arr[j]) {dup=true; } 
        }
    
     if (dup==false)
        {
        // arr2[count]=arr[i];
        // count++;
        //System.Console.Write($"{arr2[count]} ");        
        System.Console.Write($" {arr[i]} ");        
      }  
      
    }  
}
 
         
string mass = InputMass();
string []splitMass =mass.Split(' ');
double [] newMass = new double[splitMass.Length];
CreateArray(splitMass,newMass);
Console.Write("массив без дубликатов: ");
ExcludeDuplicate (newMass);           
            
            