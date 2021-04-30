
// # 1) understand the problem and write required steps

// # 2) divide the problem into smaller sections 

// # 3) genrelize the problem

// # 4) reduce the complexity of the problem

// # 5) Start with what you know

// # 6) look for examples

// # 7) Experiment the problem

// # 8) Leave if you don't find any solution

#include <stdio.h>

// values shall not be taken by you values shall be provided to you by function
// return instead of printing

// function from hackerrank
int* gradingStudents(int grades_count, int* grades, int* result_count) 
{

    // 10 multiple of 5 = 2 how did you find???



    // 5 * 2 = 10;

    // 5 * x = 10;

    // 5x = 10

    // x = 10/5

    // 100 multiple of 5 = 

    // 70 multiple of 5 = 


    // (x1 - array[i]) < 3 

    // 1) traverse through array
    for(int i = 0; i < grades_count; i++)
    {
        // 2) find the multple of 5 of the each value
        // x = array[i]/5;

        // 3) find the next multiple of 5 
        // x1 = 5 * (x+1);

        // 4) present value is already in array

        // 5) first check if array[i] > 40 
                // else    
                //     fail

        // 6) Rounding should be done


        // if((x1 - array[i]) < 3) true:
            // array[i] = x1;
            // else
            //     continue;


        int multiple_of_5 = grades[i]/5;

        int next_multiple_of_5 = 5 * (multiple_of_5 + 1);

        if(grades[i] > 40)
        {
            if((next_multiple_of_5 - grades[i]) < 3)
                grades[i] = next_multiple_of_5;
            else
                continue;
        }
        else
        {
            continue;
        }
        





    }

}

void main()
{
    int array[4] = {73,67,38,33};

    int var = 0;

    gradingStudents(4,array,&var);
)
}
