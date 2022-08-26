using System ;
    public class Program{ 
    public static void InputName() {
       
       Console.Write("Input Score");
      
       return Console.ReadLine();
    }
     
     public static string InputScore(){  
       Console.Write("input Score:");

return Console.ReadLine();
     }

static void PrintInputInfomation(string name,
string inputScore,
string grade ){
 console.WriteLine();
 Console0.WriteLine("******************************************************");
console.WriteLine("Name is : {0}",name);
Console.WriteLine("Score is : {0}", inputScore);
console.WriteLine("Grade is : {0}",grade);
console.WriteLine("********************************************************");
 
   }

    public static int ConvertStringToInt(string value){
    if (int.TryParse(value, out int number)){
    return number;
   }

    throw new Exception("Please input decimal data.");
    }

    public static string ConvertScorewToGrade(int score){
        if (score > 100 ){ throw new Exception ("Please Input data 0-100");

        if (IsGradeA (score)){
            return "Grade A";
        }else if (IsGradeBPlus(score)){
            return "Grade B+";
        }else if (IsGradeB (score)){
            return "Grade B";
        }else if (IsGradeCPlus(score)){
            return "Grade C+";
        }else if (IsGradeC (score)){
            return "Grade C";
        }else if (IsGradeDPlus(score)){
            return "Grade D+";
        }else if (IsGradeD (score)){
            return "Grade D";
        }else if (IsGradeF (score)){
            return "Grade F";
            }

         
         public static bool IsGradeA(int score) {
           return score <= 100 && score >= 80 ; 
         }

         public static bool IsGradeBPlus(int score){
            return score <80 && score >= 75 ;
         }

        public static bool IsGradeB(int score){
           return score < 75 && score >= 70 ; 
         }

         public static bool IsGradeCPlus(int score){
           return score < 70 && score >= 65 ; 
         }

         public static bool IsGradeC(int score){
           return score < 65 && score >= 60 ; 
         }

         public static bool IsGradeDPlus(int score){
           return score < 60 && score >= 55 ; 
         }

         public static bool IsGradeD(int score){
           int maxScoreGradeD = 55 ;
           int minScoreGradeD = 50 ;
 
           return score <=  maxScoreGradeD 
           && score >= minScoreGradeD
         }

        public static void Main(stirng[])
       stirng name = InputName();
       string scoreText = InputScore();
       int scoreDecimal = ConvertStringToInt(scoreText);
       string grade = ConvertScorewToGrade (scoreDecimal);
       
       PrintInputInfomation(name,scoreText,grade);
    }
}
