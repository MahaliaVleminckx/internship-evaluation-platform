using Microsoft.AspNetCore.Mvc;

namespace Howest.SelfEvaluation.Web.Models
{
    public class CheckboxModel<T>
    {
        public bool IsSelected { get; set; }
        [HiddenInput]
        public string Text { get; set; }
        [HiddenInput]
        public T Value { get; set; }
    }
}
