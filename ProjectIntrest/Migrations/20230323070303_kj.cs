using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace ProjectIntrest.Migrations
{
    public partial class kj : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Users",
                columns: table => new
                {
                    userId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    photo = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    avatarPhoto = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    nickName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    fullName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    phoneNo = table.Column<int>(type: "int", nullable: false),
                    dateTime = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Users", x => x.userId);
                });

            migrationBuilder.CreateTable(
                name: "Follower",
                columns: table => new
                {
                    followerId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    user_Id = table.Column<int>(type: "int", nullable: true),
                    followed_Id = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Follower", x => x.followerId);
                    table.ForeignKey(
                        name: "FK_Follower_Users_followed_Id",
                        column: x => x.followed_Id,
                        principalTable: "Users",
                        principalColumn: "userId");
                    table.ForeignKey(
                        name: "FK_Follower_Users_user_Id",
                        column: x => x.user_Id,
                        principalTable: "Users",
                        principalColumn: "userId");
                });

            migrationBuilder.CreateTable(
                name: "IntrestsCategory",
                columns: table => new
                {
                    intrestCategoryId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    categoryName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    user_Id = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_IntrestsCategory", x => x.intrestCategoryId);
                    table.ForeignKey(
                        name: "FK_IntrestsCategory_Users_user_Id",
                        column: x => x.user_Id,
                        principalTable: "Users",
                        principalColumn: "userId");
                });

            migrationBuilder.CreateTable(
                name: "Message",
                columns: table => new
                {
                    messageId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    user_Id = table.Column<int>(type: "int", nullable: true),
                    receiver_Id = table.Column<int>(type: "int", nullable: true),
                    actualMessage = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    messegeFile = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    dateTime = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Message", x => x.messageId);
                    table.ForeignKey(
                        name: "FK_Message_Users_receiver_Id",
                        column: x => x.receiver_Id,
                        principalTable: "Users",
                        principalColumn: "userId");
                    table.ForeignKey(
                        name: "FK_Message_Users_user_Id",
                        column: x => x.user_Id,
                        principalTable: "Users",
                        principalColumn: "userId");
                });

            migrationBuilder.CreateTable(
                name: "Post",
                columns: table => new
                {
                    postId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    text = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    audio = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    user_Id = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Post", x => x.postId);
                    table.ForeignKey(
                        name: "FK_Post_Users_user_Id",
                        column: x => x.user_Id,
                        principalTable: "Users",
                        principalColumn: "userId");
                });

            migrationBuilder.CreateTable(
                name: "Intrest",
                columns: table => new
                {
                    intrestId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    intrestName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    intrestCategory_Id = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Intrest", x => x.intrestId);
                    table.ForeignKey(
                        name: "FK_Intrest_IntrestsCategory_intrestCategory_Id",
                        column: x => x.intrestCategory_Id,
                        principalTable: "IntrestsCategory",
                        principalColumn: "intrestCategoryId");
                });

            migrationBuilder.CreateTable(
                name: "Pin",
                columns: table => new
                {
                    pinId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    user_Id = table.Column<int>(type: "int", nullable: true),
                    post_Id = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Pin", x => x.pinId);
                    table.ForeignKey(
                        name: "FK_Pin_Post_post_Id",
                        column: x => x.post_Id,
                        principalTable: "Post",
                        principalColumn: "postId");
                    table.ForeignKey(
                        name: "FK_Pin_Users_user_Id",
                        column: x => x.user_Id,
                        principalTable: "Users",
                        principalColumn: "userId");
                });

            migrationBuilder.CreateTable(
                name: "Reply",
                columns: table => new
                {
                    replyId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    user_Id = table.Column<int>(type: "int", nullable: true),
                    post_Id = table.Column<int>(type: "int", nullable: true),
                    reply = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Reply", x => x.replyId);
                    table.ForeignKey(
                        name: "FK_Reply_Post_post_Id",
                        column: x => x.post_Id,
                        principalTable: "Post",
                        principalColumn: "postId");
                    table.ForeignKey(
                        name: "FK_Reply_Users_user_Id",
                        column: x => x.user_Id,
                        principalTable: "Users",
                        principalColumn: "userId");
                });

            migrationBuilder.CreateIndex(
                name: "IX_Follower_followed_Id",
                table: "Follower",
                column: "followed_Id");

            migrationBuilder.CreateIndex(
                name: "IX_Follower_user_Id",
                table: "Follower",
                column: "user_Id");

            migrationBuilder.CreateIndex(
                name: "IX_Intrest_intrestCategory_Id",
                table: "Intrest",
                column: "intrestCategory_Id");

            migrationBuilder.CreateIndex(
                name: "IX_IntrestsCategory_user_Id",
                table: "IntrestsCategory",
                column: "user_Id");

            migrationBuilder.CreateIndex(
                name: "IX_Message_receiver_Id",
                table: "Message",
                column: "receiver_Id");

            migrationBuilder.CreateIndex(
                name: "IX_Message_user_Id",
                table: "Message",
                column: "user_Id");

            migrationBuilder.CreateIndex(
                name: "IX_Pin_post_Id",
                table: "Pin",
                column: "post_Id");

            migrationBuilder.CreateIndex(
                name: "IX_Pin_user_Id",
                table: "Pin",
                column: "user_Id");

            migrationBuilder.CreateIndex(
                name: "IX_Post_user_Id",
                table: "Post",
                column: "user_Id");

            migrationBuilder.CreateIndex(
                name: "IX_Reply_post_Id",
                table: "Reply",
                column: "post_Id");

            migrationBuilder.CreateIndex(
                name: "IX_Reply_user_Id",
                table: "Reply",
                column: "user_Id");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Follower");

            migrationBuilder.DropTable(
                name: "Intrest");

            migrationBuilder.DropTable(
                name: "Message");

            migrationBuilder.DropTable(
                name: "Pin");

            migrationBuilder.DropTable(
                name: "Reply");

            migrationBuilder.DropTable(
                name: "IntrestsCategory");

            migrationBuilder.DropTable(
                name: "Post");

            migrationBuilder.DropTable(
                name: "Users");
        }
    }
}
