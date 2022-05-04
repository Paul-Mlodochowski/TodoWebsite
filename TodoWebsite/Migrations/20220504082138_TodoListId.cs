using Microsoft.EntityFrameworkCore.Migrations;

namespace TodoWebsite.Migrations
{
    public partial class TodoListId : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Tags_TodoLists_TodoListId",
                table: "Tags");

            migrationBuilder.AlterColumn<int>(
                name: "TodoListId",
                table: "Tags",
                type: "INTEGER",
                nullable: false,
                defaultValue: 0,
                oldClrType: typeof(int),
                oldType: "INTEGER",
                oldNullable: true);

            migrationBuilder.AddForeignKey(
                name: "FK_Tags_TodoLists_TodoListId",
                table: "Tags",
                column: "TodoListId",
                principalTable: "TodoLists",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Tags_TodoLists_TodoListId",
                table: "Tags");

            migrationBuilder.AlterColumn<int>(
                name: "TodoListId",
                table: "Tags",
                type: "INTEGER",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "INTEGER");

            migrationBuilder.AddForeignKey(
                name: "FK_Tags_TodoLists_TodoListId",
                table: "Tags",
                column: "TodoListId",
                principalTable: "TodoLists",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }
    }
}
