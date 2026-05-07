namespace Howest.SelfEvaluation.Web.ViewModels.Mentor
{
    public class MentorStudentIdsViewModel
    {
        //TEMPORAL class to hold ids for routing, perhaps using cookies in the future to hold these
        //idk if good practice to hold these in cookies yet though
        public Guid MentorId { get; set; }
        public Guid StudentId { get; set; }
    }
}
