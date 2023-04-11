using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace E_Learning.Migrations
{
    /// <inheritdoc />
    public partial class eight : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_CourseStudent_Courses_CoursesId",
                table: "CourseStudent");

            migrationBuilder.DropForeignKey(
                name: "FK_CourseStudent_Students_StudentsId",
                table: "CourseStudent");

            migrationBuilder.RenameColumn(
                name: "StudentsId",
                table: "CourseStudent",
                newName: "StudentId");

            migrationBuilder.RenameColumn(
                name: "CoursesId",
                table: "CourseStudent",
                newName: "CourseId");

            migrationBuilder.RenameIndex(
                name: "IX_CourseStudent_StudentsId",
                table: "CourseStudent",
                newName: "IX_CourseStudent_StudentId");

            migrationBuilder.AlterColumn<string>(
                name: "Profile_Picture",
                table: "Students",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)");

            migrationBuilder.AlterColumn<string>(
                name: "Bio",
                table: "Students",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)");

            migrationBuilder.AddColumn<string>(
                name: "User_id",
                table: "Students",
                type: "nvarchar(450)",
                nullable: true);

            migrationBuilder.AddColumn<bool>(
                name: "IsPaid",
                table: "CourseStudent",
                type: "bit",
                nullable: false,
                defaultValue: false);

            migrationBuilder.CreateIndex(
                name: "IX_Students_User_id",
                table: "Students",
                column: "User_id");

            migrationBuilder.AddForeignKey(
                name: "FK_CourseStudent_Courses_CourseId",
                table: "CourseStudent",
                column: "CourseId",
                principalTable: "Courses",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_CourseStudent_Students_StudentId",
                table: "CourseStudent",
                column: "StudentId",
                principalTable: "Students",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Students_AspNetUsers_User_id",
                table: "Students",
                column: "User_id",
                principalTable: "AspNetUsers",
                principalColumn: "Id");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_CourseStudent_Courses_CourseId",
                table: "CourseStudent");

            migrationBuilder.DropForeignKey(
                name: "FK_CourseStudent_Students_StudentId",
                table: "CourseStudent");

            migrationBuilder.DropForeignKey(
                name: "FK_Students_AspNetUsers_User_id",
                table: "Students");

            migrationBuilder.DropIndex(
                name: "IX_Students_User_id",
                table: "Students");

            migrationBuilder.DropColumn(
                name: "User_id",
                table: "Students");

            migrationBuilder.DropColumn(
                name: "IsPaid",
                table: "CourseStudent");

            migrationBuilder.RenameColumn(
                name: "StudentId",
                table: "CourseStudent",
                newName: "StudentsId");

            migrationBuilder.RenameColumn(
                name: "CourseId",
                table: "CourseStudent",
                newName: "CoursesId");

            migrationBuilder.RenameIndex(
                name: "IX_CourseStudent_StudentId",
                table: "CourseStudent",
                newName: "IX_CourseStudent_StudentsId");

            migrationBuilder.AlterColumn<string>(
                name: "Profile_Picture",
                table: "Students",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "Bio",
                table: "Students",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Email",
                table: "Students",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "Name",
                table: "Students",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "Password",
                table: "Students",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<int>(
                name: "certificate_Id",
                table: "Courses",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddForeignKey(
                name: "FK_CourseStudent_Courses_CoursesId",
                table: "CourseStudent",
                column: "CoursesId",
                principalTable: "Courses",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_CourseStudent_Students_StudentsId",
                table: "CourseStudent",
                column: "StudentsId",
                principalTable: "Students",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
