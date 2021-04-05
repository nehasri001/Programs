int main() 
{
  int array[5] = { 10, 11, 7, 12, 14 };

  int diff;
  
  int array2[4];
  
  // 2) take adjacent values and subtract it.
  for(int i = 0;i <= 5; i ++)
  {
    diff = array[i] - array[i+1];
    
    // 3) store all the subtracted numbers in an array
    array2[i] = diff;
  }
  
  // array2[i] = {1, 4, -5, 2};
  
  // 4) find the biggest value
  
  for(int i = 0; i < 3;i ++)
  {
    
    if(array2[i] > array2[i+1])
    {
      printf("%d",array2[i]);
    }
    
  }
  
  
  
}
