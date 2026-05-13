
namespace Howest.SelfEvaluation.Web.Models
{
    public class ResultModel<T>
    {
        public T Data { get; set; }
        public bool Succes => Errors.Count() == 0;
        public List<string> Errors { get; set; }
    }
}
