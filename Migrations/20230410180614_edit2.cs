using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace E_Learning.Migrations
{
    /// <inheritdoc />
    public partial class edit2 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Courses_Enrollments_EnrollmentId",
                table: "Courses");

            migrationBuilder.DropForeignKey(
                name: "FK_Courses_Payments_PaymentId",
                table: "Courses");

            migrationBuilder.AlterColumn<int>(
                name: "PaymentId",
                table: "Courses",
                type: "int",
                nullable: false,
                defaultValue: 0,
                oldClrType: typeof(int),
                oldType: "int",
                oldNullable: true);

            migrationBuilder.AlterColumn<int>(
                name: "EnrollmentId",
                table: "Courses",
                type: "int",
                nullable: false,
                defaultValue: 0,
                oldClrType: typeof(int),
                oldType: "int",
                oldNullable: true);

            migrationBuilder.AddForeignKey(
                name: "FK_Courses_Enrollments_EnrollmentId",
                table: "Courses",
                column: "EnrollmentId",
                principalTable: "Enrollments",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Courses_Payments_PaymentId",
                table: "Courses",
                column: "PaymentId",
                principalTable: "Payments",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Courses_Enrollments_EnrollmentId",
                table: "Courses");

            migrationBuilder.DropForeignKey(
                name: "FK_Courses_Payments_PaymentId",
                table: "Courses");

            migrationBuilder.AlterColumn<int>(
                name: "PaymentId",
                table: "Courses",
                type: "int",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.AlterColumn<int>(
                name: "EnrollmentId",
                table: "Courses",
                type: "int",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.AddForeignKey(
                name: "FK_Courses_Enrollments_EnrollmentId",
                table: "Courses",
                column: "EnrollmentId",
                principalTable: "Enrollments",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_Courses_Payments_PaymentId",
                table: "Courses",
                column: "PaymentId",
                principalTable: "Payments",
                principalColumn: "Id");
        }
    }
}
