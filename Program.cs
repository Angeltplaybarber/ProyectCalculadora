using System;

// Variables
    List<decimal> typedNumbers = new List<decimal>();
    decimal result = 0;
    int typedOption = 0;
    bool running = true;
    int timespast = 0;

while (running){

try{
    DisplayHeader(timespast);

//--------------------------------- Asking the Option what they want------------------------------------------------------
    typedOption = AskingOption(typedOption);

//--------------------------------- Asking the Numbers what they want use------------------------------------------------------
//--------------------------------- ------------------------------------------------------

        switch (typedOption)
        {
            case 1: 
                AskingNumbers(typedNumbers);
                result = Add(result, typedNumbers);
                ShowResults(typedOption, result);
                break;

            case 2:
                AskingNumbers(typedNumbers);
                result = Substract(result, typedNumbers);
                ShowResults(typedOption, result);
                break;
            case 3:
                AskingNumbers(typedNumbers);
                result = Multiplication(result, typedNumbers);
                ShowResults(typedOption, result);
                break;
            case 4:
                AskingNumbers(typedNumbers);
                result = Division(result, typedNumbers);
                ShowResults(typedOption, result);
                break;
            case 5:
            running = false;
            Console.WriteLine("Thank you, have a Good Day!!");
                break;
            default:
                result = 0;
                break;
        }

    

}
    
    catch (DivideByZeroException ex)
    {
        Console.WriteLine($"you can not divide by zero: {ex.Message}");
    }
    catch (ArithmeticException ex)
    {
        Console.WriteLine($"you can not divide by zero: {ex.Message}");
    }
    catch (Exception ex)
    {
        Console.WriteLine($"You need to choose a correct option: {ex.Message}");
    }


    timespast += 1;
    typedNumbers.Clear();
    result = 0;

}    

    //function
    static decimal Add(decimal Result,List<decimal> Numbers){
        foreach (decimal typedNumber in Numbers){
            if (typedNumber == 0) {
                Result = typedNumber;
            }else{
                    Result += typedNumber;
            }
                }
        return Result;
    }

   
    static decimal Substract(decimal Result,List<decimal> Numbers){

        
        foreach (decimal typedNumber in Numbers){
            if (Result == 0) {
                Result = typedNumber;
            }else{
                Result -= typedNumber;
            }
                }
        return Result;
    }

    static decimal Multiplication(decimal Result,List<decimal> Numbers){

        foreach (decimal typedNumber in Numbers){
            if (Result == 0) {
                Result = typedNumber;
            }else{
                Result *= typedNumber;
            }
                }
        return Result;
    }

    static decimal Division(decimal Result,List<decimal> Numbers){
        foreach (decimal typedNumber in Numbers){
            if (Result == 0) {
                Result = typedNumber;
            }else{
                Result /= typedNumber;
            }
                }
        return Result;
    }

    static void DisplayHeader(int times){
        
        if(times < 1){
            Console.WriteLine("This is the best calculator");
            Console.WriteLine("Please Type the option number than you want");
            Console.WriteLine("---------------------------------------");
            Console.WriteLine("1. Sum, \n 2. Substract,  \n 3. Multiplication,  \n 4. Division,  \n 5. Exit");
        }else{
            Console.WriteLine("Please Type the option number than you want again");
            Console.WriteLine("---------------------------------------");
            Console.WriteLine("1. Sum, \n 2. Substract,  \n 3. Multiplication,  \n 4. Division,  \n 5. Exit");
        }
    }

    
static int AskingOption(int option){
    
        option = Convert.ToInt32(Console.ReadLine());
        return option;
    
}

static void AskingNumbers(List<decimal> Numbers){


int wantingContinue = 0;
    
 Console.WriteLine("Please Type the first number");
        Numbers.Add(Convert.ToDecimal(Console.ReadLine()));

        Console.WriteLine("Please Type the second number");
        Numbers.Add(Convert.ToDecimal(Console.ReadLine()));

        while (wantingContinue != 2){
            Console.WriteLine("you want to continue inserting numbers? 1. Yes, 2. No");
            wantingContinue = Convert.ToInt32(Console.ReadLine());
            
            if (wantingContinue == 1){
                int quantityElementsInTheArray = Numbers.Count + 1;

                Console.WriteLine("Please Type another number");
                Numbers.Add(Convert.ToDecimal(Console.ReadLine()));

            }
        }
    }

static void ShowResults(int option,decimal Result){
    string dialog = "";

        switch (option){
            case 1: 
                dialog = "Sum";
                Console.WriteLine($"This is the result of the {dialog}: {Result} ");
                break;

            case 2:
                 dialog = "Substraction";
                 Console.WriteLine($"This is the result of the {dialog}: {Result} ");
                break;
            case 3:
                 dialog = "Multiplication";
                 Console.WriteLine($"This is the result of the {dialog}: {Result} ");
                break;
            case 4:
                 dialog = "Division";
                 Console.WriteLine($"This is the result of the {dialog}: {Result} ");
                break;
                default:
                    Result = 0;
                    break;
    }
    
}