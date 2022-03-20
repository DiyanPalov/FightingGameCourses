using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore.Migrations;
using System.Text;

namespace FightingGameCourses.Data.Migrations
{
    public partial class AddAdminAccount : Migration
    {
        const string ADMIN_USER_GUID = "81c74d2a-9304-444a-95db-bbfc9d6bbd89";
        const string ADMIN_ROLE_GUID = "361364cf-c4fe-404e-b3df-8fcf22cd7715";

        protected override void Up(MigrationBuilder migrationBuilder)
        {
            var hasher = new PasswordHasher<ApplicationUser>();

            var passwordHash = hasher.HashPassword(null,"Password100!");

            StringBuilder sb = new StringBuilder();

            sb.AppendLine("INSERT INTO AspNetUsers(Id, UserName, NormalizedUserName,Email,EmailConfirmed,PhoneNumberConfirmed,TwoFactorEnabled,LockoutEnabled,AccessFailedCount,NormalizedEmail,PasswordHash,SecurityStamp,FirstName)");
            sb.AppendLine("VALUES(");
            sb.AppendLine($"'{ADMIN_USER_GUID}'");
            sb.AppendLine(",'admin@fightinggamescourses.co.uk'");
            sb.AppendLine(",'ADMIN@FIGHTINGGAMESCOURSES.CO.UK'");
            sb.AppendLine(",'admin@fightinggamescourses.co.uk'");
            sb.AppendLine(", 0");
            sb.AppendLine(", 0");
            sb.AppendLine(", 0");
            sb.AppendLine(", 0");
            sb.AppendLine(", 0");
            sb.AppendLine(",'ADMIN@FIGHTINGGAMESCOURSES.CO.UK'");
            sb.AppendLine($", '{passwordHash}'");
            sb.AppendLine(", ''");
            sb.AppendLine(",'Admin'");
            sb.AppendLine(")");

            migrationBuilder.Sql(sb.ToString());

            migrationBuilder.Sql($"INSERT INTO AspNetRoles (Id, Name, NormalizedName) VALUES ('{ADMIN_ROLE_GUID}','Admin','ADMIN')");

            migrationBuilder.Sql($"INSERT INTO AspNetUserRoles (UserId, RoleId) VALUES ('{ADMIN_USER_GUID}','{ADMIN_ROLE_GUID}')");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.Sql($"DELETE FROM AspNetUserRoles WHERE UserId = '{ADMIN_USER_GUID}' AND RoleId = '{ADMIN_ROLE_GUID}'");

            migrationBuilder.Sql($"DELETE FROM AspNetUsers WHERE Id = '{ADMIN_USER_GUID}'");

            migrationBuilder.Sql($"DELETE FROM AspNetRoles WHERE Id = '{ADMIN_ROLE_GUID}'");
        }
    }
}
