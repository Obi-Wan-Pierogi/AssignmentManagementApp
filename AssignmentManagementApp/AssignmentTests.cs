namespace AssignmentManagementApp
{
    public class AssignmentTests
    {
        [Fact]
        public void Assignment_Should_Have_A_Title()
        {
            var assignment = new Assignment() {
                Title = "Default Title"
            };
            Assert.NotNull(assignment.Title);
        }
    }
}
