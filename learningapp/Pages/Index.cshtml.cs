using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.Data.SqlClient;

namespace learningapp.Pages;

public class IndexModel : PageModel
{
    private readonly ILogger<IndexModel> _logger;
    public List<Course> courses = new List<Course>();
    private IConfiguration _configuration;

    public IndexModel(ILogger<IndexModel> logger, IConfiguration configuration)
    {
        _logger = logger;
        _configuration = configuration;
    }

    public void OnGet()
    {
        // string connectionString = _configuration.GetConnectionString("AZURE_SQL_CONNECTIONSTRING")!;
        // var sqlconnect = new SqlConnection(connectionString);
        // sqlconnect.Open();

        // var sqlcommand = new SqlCommand(
        //     "SELECT CourseId,CourseName,Rating FROM Course;", sqlconnect);
        // using (SqlDataReader sqlDataReader = sqlcommand.ExecuteReader())
        // {
        //     while (sqlDataReader.Read())
        //     {
        //         courses.Add(new Course()
        //         {
        //             CourseId = Int32.Parse(sqlDataReader["CourseId"].ToString()),
        //             CourseName = sqlDataReader["CourseName"].ToString(),
        //             Rating=Decimal.Parse(sqlDataReader["Rating"].ToString())
        //         });
        //     }
        // }
    }
}
