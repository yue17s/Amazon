using Microsoft.EntityFrameworkCore.Migrations;

namespace Amazon.Migrations
{
    public partial class UpdateCategoryColumn : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
           migrationBuilder.UpdateData(
           table: "Books",
           keyColumn: "BookId",
           keyValue: "9090F9E0-29AC-4185-9A8B-08D6DBEC0A24",
           column: "Category",
           value: "Technology"
           );
            migrationBuilder.UpdateData(
            table: "Books",
            keyColumn: "BookId",
            keyValue: "D41852DD-4A92-47EF-9A89-08D6DBEC0A24",
            column: "Category",
            value: "Technology"
            );
            migrationBuilder.UpdateData(
            table: "Books",
            keyColumn: "BookId",
            keyValue: "9E30C4CD-96C3-4248-9A87-08D6DBEC0A24",
            column: "Category",
            value: "History"
            );
            migrationBuilder.UpdateData(
            table: "Books",
            keyColumn: "BookId",
            keyValue: "E8730676-7B04-4B40-9A8C-08D6DBEC0A24",
            column: "Category",
            value: "Education"
            );


            migrationBuilder.UpdateData(
            table: "Books",
            keyColumn: "BookId",
            keyValue: "92C371C1-DBE0-4918-9A8D-08D6DBEC0A24",
            column: "Category",
            value: "History"
            );
            migrationBuilder.UpdateData(
            table: "Books",
            keyColumn: "BookId",
            keyValue: "E60C48A8-84D4-49EB-9A8A-08D6DBEC0A24",
            column: "Category",
            value: "Education"
            );
            migrationBuilder.UpdateData(
            table: "Books",
            keyColumn: "BookId",
            keyValue: "9E30C4CD-96C3-4248-9A87-08D6DBEC0A24",
            column: "Category",
            value: "History"
            );
            migrationBuilder.UpdateData(
            table: "Books",
            keyColumn: "BookId",
            keyValue: "EA2D512D-9124-48FC-9A88-08D6DBEC0A24",
            column: "Category",
            value: "Education"
            );
            migrationBuilder.UpdateData(
            table: "Books",
            keyColumn: "BookId",
            keyValue: "9E30C4CD-96C3-4248-9A87-08D6DBEC0A24",
            column: "Category",
            value: "History"
            );
            migrationBuilder.UpdateData(
            table: "Books",
            keyColumn: "BookId",
            keyValue: "EA2D512D-9124-48FC-9A88-08D6DBEC0A24",
            column: "Category",
            value: "Education"
            );
            migrationBuilder.UpdateData(
            table: "Books",
            keyColumn: "BookId",
            keyValue: "7EC702C6-CA50-4AF5-9A85-08D6DBEC0A24",
            column: "Category",
            value: "Engineering"
            );
            migrationBuilder.UpdateData(
            table: "Books",
            keyColumn: "BookId",
            keyValue: "6C305A86-707C-4741-9A86-08D6DBEC0A24",
            column: "Category",
            value: "Engineering"
            );
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
            table: "Books",
            keyColumn: "BookId",
            keyValue: "9090F9E0-29AC-4185-9A8B-08D6DBEC0A24",
            column: "Category",
            value: null
            );
            migrationBuilder.UpdateData(
            table: "Books",
            keyColumn: "BookId",
            keyValue: "D41852DD-4A92-47EF-9A89-08D6DBEC0A24",
            column: "Category",
            value: null
            );
            migrationBuilder.UpdateData(
            table: "Books",
            keyColumn: "BookId",
            keyValue: "9E30C4CD-96C3-4248-9A87-08D6DBEC0A24",
            column: "Category",
            value: null
            );
            migrationBuilder.UpdateData(
            table: "Books",
            keyColumn: "BookId",
            keyValue: "E8730676-7B04-4B40-9A8C-08D6DBEC0A24",
            column: "Category",
            value: null
            );


            migrationBuilder.UpdateData(
            table: "Books",
            keyColumn: "BookId",
            keyValue: "92C371C1-DBE0-4918-9A8D-08D6DBEC0A24",
            column: "Category",
            value: null
            );
            migrationBuilder.UpdateData(
            table: "Books",
            keyColumn: "BookId",
            keyValue: "E60C48A8-84D4-49EB-9A8A-08D6DBEC0A24",
            column: "Category",
            value: null
            );
            migrationBuilder.UpdateData(
            table: "Books",
            keyColumn: "BookId",
            keyValue: "9E30C4CD-96C3-4248-9A87-08D6DBEC0A24",
            column: "Category",
            value: null
            );
            migrationBuilder.UpdateData(
            table: "Books",
            keyColumn: "BookId",
            keyValue: "EA2D512D-9124-48FC-9A88-08D6DBEC0A24",
            column: "Category",
            value: null
            );
            migrationBuilder.UpdateData(
            table: "Books",
            keyColumn: "BookId",
            keyValue: "9E30C4CD-96C3-4248-9A87-08D6DBEC0A24",
            column: "Category",
            value: null
            );
            migrationBuilder.UpdateData(
            table: "Books",
            keyColumn: "BookId",
            keyValue: "EA2D512D-9124-48FC-9A88-08D6DBEC0A24",
            column: "Category",
            value: null
            );
            migrationBuilder.UpdateData(
            table: "Books",
            keyColumn: "BookId",
            keyValue: "7EC702C6-CA50-4AF5-9A85-08D6DBEC0A24",
            column: "Category",
            value: null
            );
            migrationBuilder.UpdateData(
            table: "Books",
            keyColumn: "BookId",
            keyValue: "6C305A86-707C-4741-9A86-08D6DBEC0A24",
            column: "Category",
            value: null
            );
        }
    }
}
