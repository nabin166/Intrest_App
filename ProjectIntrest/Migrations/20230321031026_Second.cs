using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace ProjectIntrest.Migrations
{
    public partial class Second : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropPrimaryKey(
                name: "PK_Messages",
                table: "Messages");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Followers",
                table: "Followers");

            migrationBuilder.RenameTable(
                name: "Messages",
                newName: "Message");

            migrationBuilder.RenameTable(
                name: "Followers",
                newName: "Follower");

            migrationBuilder.RenameColumn(
                name: "sender",
                table: "Message",
                newName: "user_Id");

            migrationBuilder.RenameColumn(
                name: "followedBy",
                table: "Follower",
                newName: "user_Id");

            migrationBuilder.AddColumn<DateTime>(
                name: "dateTime",
                table: "Message",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.AddPrimaryKey(
                name: "PK_Message",
                table: "Message",
                column: "message_Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Follower",
                table: "Follower",
                column: "followerId");

            migrationBuilder.CreateIndex(
                name: "IX_Message_user_Id",
                table: "Message",
                column: "user_Id");

            migrationBuilder.CreateIndex(
                name: "IX_Follower_user_Id",
                table: "Follower",
                column: "user_Id");

            migrationBuilder.AddForeignKey(
                name: "FK_Follower_Users_user_Id",
                table: "Follower",
                column: "user_Id",
                principalTable: "Users",
                principalColumn: "user_Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Message_Users_user_Id",
                table: "Message",
                column: "user_Id",
                principalTable: "Users",
                principalColumn: "user_Id",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Follower_Users_user_Id",
                table: "Follower");

            migrationBuilder.DropForeignKey(
                name: "FK_Message_Users_user_Id",
                table: "Message");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Message",
                table: "Message");

            migrationBuilder.DropIndex(
                name: "IX_Message_user_Id",
                table: "Message");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Follower",
                table: "Follower");

            migrationBuilder.DropIndex(
                name: "IX_Follower_user_Id",
                table: "Follower");

            migrationBuilder.DropColumn(
                name: "dateTime",
                table: "Message");

            migrationBuilder.RenameTable(
                name: "Message",
                newName: "Messages");

            migrationBuilder.RenameTable(
                name: "Follower",
                newName: "Followers");

            migrationBuilder.RenameColumn(
                name: "user_Id",
                table: "Messages",
                newName: "sender");

            migrationBuilder.RenameColumn(
                name: "user_Id",
                table: "Followers",
                newName: "followedBy");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Messages",
                table: "Messages",
                column: "message_Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Followers",
                table: "Followers",
                column: "followerId");
        }
    }
}
