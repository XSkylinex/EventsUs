using Microsoft.EntityFrameworkCore.Migrations;

namespace EventsUs.Data.Migrations
{
    public partial class dviros : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "age",
                table: "AspNetUsers",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[,]
                {
                    { "2", "admin", "admin", "admin" },
                    { "1", "user", "user", "user" }
                });

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "ConcurrencyStamp", "Email", "EmailConfirmed", "LockoutEnabled", "LockoutEnd", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "SecurityStamp", "TwoFactorEnabled", "UserName", "age" },
                values: new object[,]
                {
                    { "Eu_7019", 0, "9c459224-19c3-4378-80fa-f165b8aa5b00", "Eu_7019@eventus.com", true, true, null, "Eu_7019@eventus.com", "Eu_7019@eventus.com", "AQAAAAEAACcQAAAAENoxvAv86sjv5pEy9+L4x+rJTCK9cwbodALA7J+ldlpaaQ7k5gIVY9iVLMYHaOJ4mQ==", null, false, "Eu_7019@eventus.com", false, "EventUs_Eu_7019", 20 },
                    { "Eu_7018", 0, "123ae28a-45d7-4f23-a931-ddbe9992a846", "Eu_7018@eventus.com", true, true, null, "Eu_7018@eventus.com", "Eu_7018@eventus.com", "AQAAAAEAACcQAAAAEJHQKeFvjp1BLAxc5FiYO5txdlGH9lr/0tj1nzuxzMx5VIfZLPmqoVl4gkuNx4f3+g==", null, false, "Eu_7018@eventus.com", false, "EventUs_Eu_7018", 20 },
                    { "Eu_7017", 0, "68f3fc69-99e1-443c-a5d2-6c3f6a365bae", "Eu_7017@eventus.com", true, true, null, "Eu_7017@eventus.com", "Eu_7017@eventus.com", "AQAAAAEAACcQAAAAEEjXOJUuSwEdVvTN9yBkQ/3td0ZdyBhyCU5cq5iTd1O5GzyhsaEs++44H0Zai5xM7A==", null, false, "Eu_7017@eventus.com", false, "EventUs_Eu_7017", 20 },
                    { "Eu_7016", 0, "661d1490-093a-4928-8ecf-508350d7a893", "Eu_7016@eventus.com", true, true, null, "Eu_7016@eventus.com", "Eu_7016@eventus.com", "AQAAAAEAACcQAAAAEBecQiXSNMON8VmrGaQXjjwgjfp03RkSBgBlTvd+j0uEUrl13Z4VVcn75TEwUi2MTw==", null, false, "Eu_7016@eventus.com", false, "EventUs_Eu_7016", 20 },
                    { "Eu_7015", 0, "f55bddd0-2dd1-48de-b794-500ce2367dc6", "Eu_7015@eventus.com", true, true, null, "Eu_7015@eventus.com", "Eu_7015@eventus.com", "AQAAAAEAACcQAAAAEAPsj53vmD2nve5CNwpTbYqBTN0ANyniMfrPkTRLv/da3kVgP+qWB6liTPtgR4LPCQ==", null, false, "Eu_7015@eventus.com", false, "EventUs_Eu_7015", 20 },
                    { "Eu_7014", 0, "e1f3efa6-cce7-49a9-add5-8fcf31f26bb1", "Eu_7014@eventus.com", true, true, null, "Eu_7014@eventus.com", "Eu_7014@eventus.com", "AQAAAAEAACcQAAAAEMeQM+Oj87nqGrzgZZxQ0mbfgT9Lf9uKyCMyaO1DaD5hF/JQtjmh/2yyZHISnEG/ww==", null, false, "Eu_7014@eventus.com", false, "EventUs_Eu_7014", 20 },
                    { "Eu_7013", 0, "8321aa16-c75a-4664-a82f-f3eeb045f1e6", "Eu_7013@eventus.com", true, true, null, "Eu_7013@eventus.com", "Eu_7013@eventus.com", "AQAAAAEAACcQAAAAENAhcaAPlZW/gjpo/5qbSly+zQlOD22bS2fb1QfJRKoBcNaClR+w9boDKVb8gX3FZQ==", null, false, "Eu_7013@eventus.com", false, "EventUs_Eu_7013", 20 },
                    { "Eu_7012", 0, "5d89dde6-be1a-4527-b055-a941bbd89400", "Eu_7012@eventus.com", true, true, null, "Eu_7012@eventus.com", "Eu_7012@eventus.com", "AQAAAAEAACcQAAAAEG9Hm27QLJV/BgTi179xNFH0xP+lxlI3hXCvCtljgTSHA2D0k/lr/VD38glbQCmqlg==", null, false, "Eu_7012@eventus.com", false, "EventUs_Eu_7012", 20 },
                    { "Eu_7011", 0, "17bbfed4-e83c-45bb-bf4f-3052ac39a1b7", "Eu_7011@eventus.com", true, true, null, "Eu_7011@eventus.com", "Eu_7011@eventus.com", "AQAAAAEAACcQAAAAELRpfVdFJXDlDrp0pP4uWEFzLlgmIjqBIFE4DAwxB8+9xVAj24bN+ATLm66F8Tt9EQ==", null, false, "Eu_7011@eventus.com", false, "EventUs_Eu_7011", 20 },
                    { "Eu_7010", 0, "98f7ba2a-4352-4929-a6d3-eda658821d1a", "Eu_7010@eventus.com", true, true, null, "Eu_7010@eventus.com", "Eu_7010@eventus.com", "AQAAAAEAACcQAAAAEC+J8LdY4017NdJAZeJR/ovqHYJCjhpNFvg8zIrv+SlX+OmaRp21PAYG7N1uX2xuYQ==", null, false, "Eu_7010@eventus.com", false, "EventUs_Eu_7010", 20 },
                    { "Eu_7008", 0, "49691df2-882d-44e1-9d7f-73cb4cd1c17f", "Eu_7008@eventus.com", true, true, null, "Eu_7008@eventus.com", "Eu_7008@eventus.com", "AQAAAAEAACcQAAAAEEBzycVYgwDm/xE2Krshw7IUaE0F6a/hN83YKQmL93GusmWy9Cls4IbfBeqHSBblXw==", null, false, "Eu_7008@eventus.com", false, "EventUs_Eu_7008", 20 },
                    { "Eu_7007", 0, "6477d1c8-b46e-4927-b69b-239f43dc5882", "Eu_7007@eventus.com", true, true, null, "Eu_7007@eventus.com", "Eu_7007@eventus.com", "AQAAAAEAACcQAAAAEIWA9Bqihl8XH9xQxsn02Ot1ELdrXtCchsJ7Tomk6oDKKaVNSOjaC4ONirkQ1yaeKw==", null, false, "Eu_7007@eventus.com", false, "EventUs_Eu_7007", 20 },
                    { "Eu_7006", 0, "99c265bb-fcdf-4047-be51-9983baf26da7", "Eu_7006@eventus.com", true, true, null, "Eu_7006@eventus.com", "Eu_7006@eventus.com", "AQAAAAEAACcQAAAAEPv8ZfFhQ64lwRIwGo9aYGIuYX+l5nk/ALH/VSqjbI8dW38uNDYfxAIa7baOZIgKew==", null, false, "Eu_7006@eventus.com", false, "EventUs_Eu_7006", 20 },
                    { "Eu_7005", 0, "3e513018-2eb2-43fa-ac29-36844264bd4f", "Eu_7005@eventus.com", true, true, null, "Eu_7005@eventus.com", "Eu_7005@eventus.com", "AQAAAAEAACcQAAAAEKAhksfYCnBP8m4lSq/iXVoxJcYonxPt5FTMzBaOBaoiFyzxxDf2tFSohXZleIV/Cw==", null, false, "Eu_7005@eventus.com", false, "EventUs_Eu_7005", 20 },
                    { "Eu_7004", 0, "986f90ac-e49a-4744-94a7-facd95a8a5de", "Eu_7004@eventus.com", true, true, null, "Eu_7004@eventus.com", "Eu_7004@eventus.com", "AQAAAAEAACcQAAAAEOjEpzCAJBkjiuiuDWSorVhP4ylN9Xv89Z5KZ+tjdc9206Elx+SXIDC/Le22DY/9Hg==", null, false, "Eu_7004@eventus.com", false, "EventUs_Eu_7004", 20 },
                    { "Eu_7003", 0, "0899418d-c7c4-4169-983f-37d5e9f9d1c1", "Eu_7003@eventus.com", true, true, null, "Eu_7003@eventus.com", "Eu_7003@eventus.com", "AQAAAAEAACcQAAAAEBpQMPQU0bYmG2vXW4EScsIEcIspmDNH7TNOVzi4wLomGqSSVDeW9lMtkCQAcC7WZg==", null, false, "Eu_7003@eventus.com", false, "EventUs_Eu_7003", 20 },
                    { "Eu_7002", 0, "9009515a-e943-42d2-a244-ef9819000901", "Eu_7002@eventus.com", true, true, null, "Eu_7002@eventus.com", "Eu_7002@eventus.com", "AQAAAAEAACcQAAAAEHKAQNM62jo2VGvQkSlj2KB6RoKSbhXCxKx0snt/xL1ZQHirZSXq2w8DkrjToPhX9g==", null, false, "Eu_7002@eventus.com", false, "EventUs_Eu_7002", 20 },
                    { "Eu_7001", 0, "8b7954e6-f18b-4bf9-a984-56a9b631d453", "Eu_7001@eventus.com", true, true, null, "Eu_7001@eventus.com", "Eu_7001@eventus.com", "AQAAAAEAACcQAAAAEHG14C8ziw07ozDsMlUuKu38DO3RlPjLBnnPkvWPNGcOuZyO8Ehwisk9KAbRtGyy8g==", null, false, "Eu_7001@eventus.com", false, "EventUs_Eu_7001", 20 },
                    { "Eu_7000", 0, "bb735e47-dc6a-420c-b773-35b82806a6e4", "Eu_7000@eventus.com", true, true, null, "Eu_7000@eventus.com", "Eu_7000@eventus.com", "AQAAAAEAACcQAAAAEDcLUdcbyYsc1ww89yLRHsURcUpsAsgaPLymAlnbCrtTsReAiaHXp91fWpqtl+r4Ag==", null, false, "Eu_7000@eventus.com", false, "EventUs_Eu_7000", 20 },
                    { "Eu_7009", 0, "d9e93f42-c910-4171-b346-f59ec2f7c6bc", "Eu_7009@eventus.com", true, true, null, "Eu_7009@eventus.com", "Eu_7009@eventus.com", "AQAAAAEAACcQAAAAEBA5AbfM98rhta6HvF5Ozf67Nk3ygKyy+Hr16uQUG2sb/9WFLZm7/l3nwAKupyaINw==", null, false, "Eu_7009@eventus.com", false, "EventUs_Eu_7009", 20 },
                    { "admin_ID_123456789", 0, "9d487129-a381-47a3-a895-007d3539827d", "admin@eventus.com", true, true, null, "admin@eventus.com", "admin@eventus.com", "AQAAAAEAACcQAAAAECRct49/c+MzfHdXCJZyymRzQg1cadtdsiIw3km7dUMkZ/8tcd8UVofDvLd3TpKP7g==", null, false, "admin@eventus.com", false, "admin", 0 }
                });

            migrationBuilder.InsertData(
                table: "AspNetUserRoles",
                columns: new[] { "UserId", "RoleId" },
                values: new object[,]
                {
                    { "Eu_7000", "1" },
                    { "Eu_7018", "1" },
                    { "Eu_7017", "1" },
                    { "Eu_7016", "1" },
                    { "Eu_7015", "1" },
                    { "Eu_7014", "1" },
                    { "Eu_7013", "1" },
                    { "Eu_7012", "1" },
                    { "Eu_7011", "1" },
                    { "Eu_7019", "1" },
                    { "Eu_7010", "1" },
                    { "Eu_7008", "1" },
                    { "Eu_7007", "1" },
                    { "Eu_7006", "1" },
                    { "Eu_7005", "1" },
                    { "Eu_7004", "1" },
                    { "Eu_7003", "1" },
                    { "Eu_7002", "1" },
                    { "Eu_7001", "1" },
                    { "Eu_7009", "1" },
                    { "admin_ID_123456789", "2" }
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "UserId", "RoleId" },
                keyValues: new object[] { "admin_ID_123456789", "2" });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "UserId", "RoleId" },
                keyValues: new object[] { "Eu_7000", "1" });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "UserId", "RoleId" },
                keyValues: new object[] { "Eu_7001", "1" });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "UserId", "RoleId" },
                keyValues: new object[] { "Eu_7002", "1" });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "UserId", "RoleId" },
                keyValues: new object[] { "Eu_7003", "1" });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "UserId", "RoleId" },
                keyValues: new object[] { "Eu_7004", "1" });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "UserId", "RoleId" },
                keyValues: new object[] { "Eu_7005", "1" });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "UserId", "RoleId" },
                keyValues: new object[] { "Eu_7006", "1" });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "UserId", "RoleId" },
                keyValues: new object[] { "Eu_7007", "1" });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "UserId", "RoleId" },
                keyValues: new object[] { "Eu_7008", "1" });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "UserId", "RoleId" },
                keyValues: new object[] { "Eu_7009", "1" });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "UserId", "RoleId" },
                keyValues: new object[] { "Eu_7010", "1" });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "UserId", "RoleId" },
                keyValues: new object[] { "Eu_7011", "1" });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "UserId", "RoleId" },
                keyValues: new object[] { "Eu_7012", "1" });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "UserId", "RoleId" },
                keyValues: new object[] { "Eu_7013", "1" });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "UserId", "RoleId" },
                keyValues: new object[] { "Eu_7014", "1" });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "UserId", "RoleId" },
                keyValues: new object[] { "Eu_7015", "1" });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "UserId", "RoleId" },
                keyValues: new object[] { "Eu_7016", "1" });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "UserId", "RoleId" },
                keyValues: new object[] { "Eu_7017", "1" });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "UserId", "RoleId" },
                keyValues: new object[] { "Eu_7018", "1" });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "UserId", "RoleId" },
                keyValues: new object[] { "Eu_7019", "1" });

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumns: new[] { "Id", "ConcurrencyStamp" },
                keyValues: new object[] { "1", "user" });

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumns: new[] { "Id", "ConcurrencyStamp" },
                keyValues: new object[] { "2", "admin" });

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumns: new[] { "Id", "ConcurrencyStamp" },
                keyValues: new object[] { "admin_ID_123456789", "9d487129-a381-47a3-a895-007d3539827d" });

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumns: new[] { "Id", "ConcurrencyStamp" },
                keyValues: new object[] { "Eu_7000", "bb735e47-dc6a-420c-b773-35b82806a6e4" });

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumns: new[] { "Id", "ConcurrencyStamp" },
                keyValues: new object[] { "Eu_7001", "8b7954e6-f18b-4bf9-a984-56a9b631d453" });

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumns: new[] { "Id", "ConcurrencyStamp" },
                keyValues: new object[] { "Eu_7002", "9009515a-e943-42d2-a244-ef9819000901" });

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumns: new[] { "Id", "ConcurrencyStamp" },
                keyValues: new object[] { "Eu_7003", "0899418d-c7c4-4169-983f-37d5e9f9d1c1" });

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumns: new[] { "Id", "ConcurrencyStamp" },
                keyValues: new object[] { "Eu_7004", "986f90ac-e49a-4744-94a7-facd95a8a5de" });

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumns: new[] { "Id", "ConcurrencyStamp" },
                keyValues: new object[] { "Eu_7005", "3e513018-2eb2-43fa-ac29-36844264bd4f" });

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumns: new[] { "Id", "ConcurrencyStamp" },
                keyValues: new object[] { "Eu_7006", "99c265bb-fcdf-4047-be51-9983baf26da7" });

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumns: new[] { "Id", "ConcurrencyStamp" },
                keyValues: new object[] { "Eu_7007", "6477d1c8-b46e-4927-b69b-239f43dc5882" });

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumns: new[] { "Id", "ConcurrencyStamp" },
                keyValues: new object[] { "Eu_7008", "49691df2-882d-44e1-9d7f-73cb4cd1c17f" });

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumns: new[] { "Id", "ConcurrencyStamp" },
                keyValues: new object[] { "Eu_7009", "d9e93f42-c910-4171-b346-f59ec2f7c6bc" });

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumns: new[] { "Id", "ConcurrencyStamp" },
                keyValues: new object[] { "Eu_7010", "98f7ba2a-4352-4929-a6d3-eda658821d1a" });

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumns: new[] { "Id", "ConcurrencyStamp" },
                keyValues: new object[] { "Eu_7011", "17bbfed4-e83c-45bb-bf4f-3052ac39a1b7" });

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumns: new[] { "Id", "ConcurrencyStamp" },
                keyValues: new object[] { "Eu_7012", "5d89dde6-be1a-4527-b055-a941bbd89400" });

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumns: new[] { "Id", "ConcurrencyStamp" },
                keyValues: new object[] { "Eu_7013", "8321aa16-c75a-4664-a82f-f3eeb045f1e6" });

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumns: new[] { "Id", "ConcurrencyStamp" },
                keyValues: new object[] { "Eu_7014", "e1f3efa6-cce7-49a9-add5-8fcf31f26bb1" });

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumns: new[] { "Id", "ConcurrencyStamp" },
                keyValues: new object[] { "Eu_7015", "f55bddd0-2dd1-48de-b794-500ce2367dc6" });

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumns: new[] { "Id", "ConcurrencyStamp" },
                keyValues: new object[] { "Eu_7016", "661d1490-093a-4928-8ecf-508350d7a893" });

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumns: new[] { "Id", "ConcurrencyStamp" },
                keyValues: new object[] { "Eu_7017", "68f3fc69-99e1-443c-a5d2-6c3f6a365bae" });

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumns: new[] { "Id", "ConcurrencyStamp" },
                keyValues: new object[] { "Eu_7018", "123ae28a-45d7-4f23-a931-ddbe9992a846" });

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumns: new[] { "Id", "ConcurrencyStamp" },
                keyValues: new object[] { "Eu_7019", "9c459224-19c3-4378-80fa-f165b8aa5b00" });

            migrationBuilder.DropColumn(
                name: "age",
                table: "AspNetUsers");
        }
    }
}
