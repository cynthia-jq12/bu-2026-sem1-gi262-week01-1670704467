using UnityEngine;

public class Assignment : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        // As01_CheckNumberSign();
        // As02_GetDayName();
        // As03_ValidatePassword();
        // As04_GetGrade();
        // As05_IsLeapYear();
        // As06_Calculate();
        // As07_GetSeason();
        // As08_PurchasingSystemExample();
        // As09_RockPaperScissorsExample();
        // As10_CalculateWeaponDamage();
        // As11_DeterminePlayerRank();
    }

    public int as01Number;
    public void As01_CheckNumberSign()
    {
        // TODO: Implement logic to determine sign
        // Example: Debug.Log("Positive");

        if (as01Number == 0) 
        {
            Debug.Log("Zero"); return;
        }
        if (as01Number > 0)
        {
            Debug.Log("Positive"); return;
        }
        Debug.Log("Negative");
    }

    public int as02Day;
    public void As02_GetDayName()
    {
        // TODO: Implement logic to return day name
        // Example: Debug.Log("Monday");
        string dayName = as02Day switch
        {
            1 => "Monday",
            2 => "Tuesday",
            3 => "Wednesday",
            4 => "Thursday",
            5 => "Friday",
            6 => "Saturday",
            7 => "Sunday",
            _ => "Invalid day"
        };
        Debug.Log(dayName);
    }

    public string as03InputPassword;
    public string as03CorrectPassword;
    public void As03_ValidatePassword()
    {
        // TODO: Implement password validation logic
        // Example: Debug.Log("True");

        Debug.Log(as03InputPassword == as03CorrectPassword ? "True" : "False");
    }

    public int as04Score;
    public void As04_GetGrade()
    {
        // TODO: Implement logic to return grade
        // Example: Debug.Log("A");

        if (as04Score >= 80)
        {
            Debug.Log("A"); return;
        }
        if (as04Score >= 70)
        {
            Debug.Log("B"); return;
        }
        if (as04Score >= 60)
        {
            Debug.Log("C"); return; 
        }
        if (as04Score >= 50) 
        {
            Debug.Log("D"); return;
        }
        Debug.Log("F");
    }

    public int as05Year;
    public void As05_IsLeapYear()
    {
        // TODO: Implement leap year check logic
        // Example: Debug.Log("True");

        bool isLeap = (as05Year % 400 == 0) || (as05Year % 4 == 0 && as05Year % 100 != 0);
        Debug.Log(isLeap ? "True" : "False");
    }

    public double as06Num1;
    public char as06Op;
    public double as06Num2;
    public void As06_Calculate()
    {
        // TODO: Implement calculator logic
        // Example: Debug.Log("Result: 42");

        if (as06Op == '/' && as06Num2 == 0)
        {
            Debug.Log("Error: Cannot divide by zero.");
            return;
        }

        switch (as06Op)
        {
            case '+': Debug.Log($"Result: {as06Num1 + as06Num2}"); break;
            case '-': Debug.Log($"Result: {as06Num1 - as06Num2}"); break;
            case '*': Debug.Log($"Result: {as06Num1 * as06Num2}"); break;
            case '/': Debug.Log($"Result: {as06Num1 / as06Num2}"); break;
            default: Debug.Log("Invalid operator. Please use +, -, *, or /."); break;
        }
    }

    public int as07Month;
    public void As07_GetSeason()
    {
        // TODO: Implement logic to return season
        // Example: Debug.Log("Summer");

        switch (as07Month)
        {
            case 12: case 1: case 2: Debug.Log("It's Winter."); break;
            case 3: case 4: case 5: Debug.Log("It's Spring."); break;
            case 6: case 7: case 8: Debug.Log("It's Summer."); break;
            case 9: case 10: case 11: Debug.Log("It's Fall."); break;
            default: Debug.Log("Invalid month number. Please enter a number between 1 and 12."); break;
        }
    }

    public int as08Quantity;
    public int as08Price;
    public int as08Payment;
    public void As08_PurchasingSystemExample()
    {
        if (as08Quantity <= 0) 
        {
            Debug.Log("out"); return; 
        }
        if (as08Payment < as08Price) 
        { Debug.Log("not enih"); return;
        }

        Debug.Log("???????????????????");
        if (as08Payment > as08Price)
            Debug.Log($"???????????????? {as08Payment - as08Price} ???");
    }

    public int as09UserChoice;
    public int as09ComputerChoice;
    public void As09_RockPaperScissorsExample()
    {
        throw new System.NotImplementedException();
    }

    public string as10WeaponType;
    public int as10BaseDamage;
    public void As10_CalculateWeaponDamage()
    {
        // TODO: Add your implementation here
        // Example: Debug.Log("result as string");
        throw new System.NotImplementedException();
    }

    public int as11Score;
    public int as11CompletionTime;
    public void As11_DeterminePlayerRank()
    {
        // TODO: Add your implementation here
        // Example: Debug.Log("result as string");
        throw new System.NotImplementedException();
    }
}
