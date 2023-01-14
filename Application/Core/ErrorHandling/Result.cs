namespace Eventsocity.Application.Core.ErrorHandling;
public class Result<T> where T : class
{
   public bool IsSuccess { get; set; }
   public string Error {get; set;} = "";
   public T Value {get; set;}

   // methods to return object of this class in case of faliur or success 
   public static Result<T> Success(T response) => new Result<T> {IsSuccess=true, Value=response};

   public static Result<T> Faliure(string response) => new Result<T> {IsSuccess=false, Error=response};
}