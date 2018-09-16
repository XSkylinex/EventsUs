using Microsoft.EntityFrameworkCore.Migrations;

namespace EventsUs.Data.Migrations
{
    public partial class adddemousers : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
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
                    { "rt_7019", 0, "689b79cc-af5b-41c9-82ad-54c369d20ee9", "rt_7019@RaringsTest.com", true, true, null, "rt_7019@RaringsTest.com", "rt_7019@RaringsTest.com", "AQAAAAEAACcQAAAAELGCLNYpS1yD4RqeUtBtwBsOxhOA9GOk45EuQbCemXBQF3UY1ip/tYk1nXy5+tbwyg==", null, false, "rt_7019@RaringsTest.com", false, "RaringsTest_rt_7019", 20 },
                    { "rt_7018", 0, "fa102398-c560-40a9-93c7-ae7b2af3c027", "rt_7018@RaringsTest.com", true, true, null, "rt_7018@RaringsTest.com", "rt_7018@RaringsTest.com", "AQAAAAEAACcQAAAAEJ8pg+Ss75SOkRnFhtvdmKjUt15saWTD9d0D0xsNi8Hl0m8HEMHWI9hFzXpoddaDSw==", null, false, "rt_7018@RaringsTest.com", false, "RaringsTest_rt_7018", 20 },
                    { "rt_7017", 0, "a88e3f3b-259c-4018-93ac-723faf5995c3", "rt_7017@RaringsTest.com", true, true, null, "rt_7017@RaringsTest.com", "rt_7017@RaringsTest.com", "AQAAAAEAACcQAAAAECtGQLHO3HFqX8/NNKqBUBttb6emGV+nRBa2Ni9A3f+JMMAVue7SHjLmMJtAP60RLA==", null, false, "rt_7017@RaringsTest.com", false, "RaringsTest_rt_7017", 20 },
                    { "rt_7016", 0, "d210712c-567a-4f8c-a995-c2458ebf1380", "rt_7016@RaringsTest.com", true, true, null, "rt_7016@RaringsTest.com", "rt_7016@RaringsTest.com", "AQAAAAEAACcQAAAAELxSyNCTXSBs2atOd8qB7WHa8LKgsqO0UTeHLTvDhBgbC+svEVq4PCR4NUPGWSbNTg==", null, false, "rt_7016@RaringsTest.com", false, "RaringsTest_rt_7016", 20 },
                    { "rt_7015", 0, "7fe94851-7d7b-4a18-b243-96714fa94ac5", "rt_7015@RaringsTest.com", true, true, null, "rt_7015@RaringsTest.com", "rt_7015@RaringsTest.com", "AQAAAAEAACcQAAAAELJRAKlAA66FMGjS9uAT8f23wZXU8P2TH350WVT8yYcMCz299RB2jmU5VGMNjTrG1g==", null, false, "rt_7015@RaringsTest.com", false, "RaringsTest_rt_7015", 20 },
                    { "rt_7014", 0, "2be8a42a-c742-4c52-83b1-3777f1f94f10", "rt_7014@RaringsTest.com", true, true, null, "rt_7014@RaringsTest.com", "rt_7014@RaringsTest.com", "AQAAAAEAACcQAAAAEGDRUOzj6klH+PvWsElLD3etG5NMIiD8H0i9voY50SbIVy3tE68VUvHayj79y67U+w==", null, false, "rt_7014@RaringsTest.com", false, "RaringsTest_rt_7014", 20 },
                    { "rt_7013", 0, "aa7640c2-1f91-4da0-84f6-5c215951cf43", "rt_7013@RaringsTest.com", true, true, null, "rt_7013@RaringsTest.com", "rt_7013@RaringsTest.com", "AQAAAAEAACcQAAAAEN59dgsQUjJxR/80HeJwfwMs4siq9NQ8Hrw7hAzilrkjyK+kac7GK6QLXaqAKbQF0A==", null, false, "rt_7013@RaringsTest.com", false, "RaringsTest_rt_7013", 20 },
                    { "rt_7012", 0, "0163fcd3-42d4-4a02-a678-58754d711bd7", "rt_7012@RaringsTest.com", true, true, null, "rt_7012@RaringsTest.com", "rt_7012@RaringsTest.com", "AQAAAAEAACcQAAAAEDwEJPsNjb9SpGfyN8C3lb1OMfQxKVqoxanCHxD20w8J8FkiCJalgvdGF8uHlYK6iw==", null, false, "rt_7012@RaringsTest.com", false, "RaringsTest_rt_7012", 20 },
                    { "rt_7011", 0, "02dc3620-dbd5-4544-8415-991ced8b8b36", "rt_7011@RaringsTest.com", true, true, null, "rt_7011@RaringsTest.com", "rt_7011@RaringsTest.com", "AQAAAAEAACcQAAAAEBSNzmrNSdY2d+3eSTdupZWagNtM2ZGZL8GONWmlcnFREfkuRLwqs+vXba4t+XFevQ==", null, false, "rt_7011@RaringsTest.com", false, "RaringsTest_rt_7011", 20 },
                    { "rt_7010", 0, "08dce447-5866-4fa7-9085-c97269866786", "rt_7010@RaringsTest.com", true, true, null, "rt_7010@RaringsTest.com", "rt_7010@RaringsTest.com", "AQAAAAEAACcQAAAAEBIM1M9j9Fpb4Ml8nJ2Z43XNgEB1on9v9QM+JLvGhe47ZAILPw7MdaBShPbxQ1zZtw==", null, false, "rt_7010@RaringsTest.com", false, "RaringsTest_rt_7010", 20 },
                    { "rt_7008", 0, "b58b6e11-38e7-4c8c-8383-1bbd74fa285f", "rt_7008@RaringsTest.com", true, true, null, "rt_7008@RaringsTest.com", "rt_7008@RaringsTest.com", "AQAAAAEAACcQAAAAEMkwXW1luWItugMxdZAnBVXgtgSILDPHSbKw2siYuhbjt050Mp8zfso0EJ3TqzkTGw==", null, false, "rt_7008@RaringsTest.com", false, "RaringsTest_rt_7008", 20 },
                    { "rt_7007", 0, "db8fa27e-488c-4b41-93c3-d860ed88913a", "rt_7007@RaringsTest.com", true, true, null, "rt_7007@RaringsTest.com", "rt_7007@RaringsTest.com", "AQAAAAEAACcQAAAAEKKZwFyXpMdey1otc6IFSUC5VgukSWhddWHsc+k67e7GFgepMP5diG5qDL+5VDpaCg==", null, false, "rt_7007@RaringsTest.com", false, "RaringsTest_rt_7007", 20 },
                    { "rt_7006", 0, "48f27f2f-2c22-42f9-8a63-270d7287fa80", "rt_7006@RaringsTest.com", true, true, null, "rt_7006@RaringsTest.com", "rt_7006@RaringsTest.com", "AQAAAAEAACcQAAAAEKkZb/ZP+CLLdOJsBMcAvykBd0f4LJzTGJK3GYeT9UkLMrcA0Wb7KgE+7tUMEJaiyQ==", null, false, "rt_7006@RaringsTest.com", false, "RaringsTest_rt_7006", 20 },
                    { "rt_7005", 0, "f8ad9897-8bec-46a8-9aae-a5bc15ac0b7e", "rt_7005@RaringsTest.com", true, true, null, "rt_7005@RaringsTest.com", "rt_7005@RaringsTest.com", "AQAAAAEAACcQAAAAEO26SOAMZQQQ6jgwLnz6633YHYcRhFi8wRCnstzmjNDid+LaPysWAVRimMbbAcN8lQ==", null, false, "rt_7005@RaringsTest.com", false, "RaringsTest_rt_7005", 20 },
                    { "rt_7004", 0, "62ee07a1-8cc6-4de2-90dd-9ef8633974cf", "rt_7004@RaringsTest.com", true, true, null, "rt_7004@RaringsTest.com", "rt_7004@RaringsTest.com", "AQAAAAEAACcQAAAAEMXVg6m3kFm6mEqi69jwEbB3bKHltEq7Mrw7VnBXSyftt8u5oYqRr6KbnUl7kKPWew==", null, false, "rt_7004@RaringsTest.com", false, "RaringsTest_rt_7004", 20 },
                    { "rt_7003", 0, "49975d99-a23f-47e6-85fd-09dc880590ff", "rt_7003@RaringsTest.com", true, true, null, "rt_7003@RaringsTest.com", "rt_7003@RaringsTest.com", "AQAAAAEAACcQAAAAEB2XMELuYQwXQwYJMLwQsx8p4SFJ9/coAhZQhdI+NUqhBHQlzY/8qN6sVaax57VrKA==", null, false, "rt_7003@RaringsTest.com", false, "RaringsTest_rt_7003", 20 },
                    { "rt_7002", 0, "5c082473-0159-43c3-a67a-5d4bc967b63e", "rt_7002@RaringsTest.com", true, true, null, "rt_7002@RaringsTest.com", "rt_7002@RaringsTest.com", "AQAAAAEAACcQAAAAEEtZUZ7GQUITfCIFeggVQlBTRnP3C4p8ltqvypMyiM9j7V1e/Q70L1d7oytvSH36BA==", null, false, "rt_7002@RaringsTest.com", false, "RaringsTest_rt_7002", 20 },
                    { "rt_7001", 0, "ffd39fe7-fb33-4452-9846-59f717fa9628", "rt_7001@RaringsTest.com", true, true, null, "rt_7001@RaringsTest.com", "rt_7001@RaringsTest.com", "AQAAAAEAACcQAAAAEE6hfpXkQbii6BV0+BtQLdImr4bnf0xbfyFzXEBR3C0Uv8ZeRYzs32Hsp+y2EFP+xA==", null, false, "rt_7001@RaringsTest.com", false, "RaringsTest_rt_7001", 20 },
                    { "rt_7000", 0, "baddaea9-38b4-4350-be1b-9f2578ce8935", "rt_7000@RaringsTest.com", true, true, null, "rt_7000@RaringsTest.com", "rt_7000@RaringsTest.com", "AQAAAAEAACcQAAAAED3eoLdZJa0Mhz1CmcCWSYzm51US448J2XyeKti6DrqstuXvAThY2KnO3dtXCTy9Qg==", null, false, "rt_7000@RaringsTest.com", false, "RaringsTest_rt_7000", 20 },
                    { "rt_7009", 0, "48f6becf-75eb-415d-b6f1-ddd96cb02c35", "rt_7009@RaringsTest.com", true, true, null, "rt_7009@RaringsTest.com", "rt_7009@RaringsTest.com", "AQAAAAEAACcQAAAAEBRbBRjRaTlhHrV0I0Qiv6Tz2Rh1EnbjtCgBcgxswJ7UNmaixREOzBPPAxIMI5fENA==", null, false, "rt_7009@RaringsTest.com", false, "RaringsTest_rt_7009", 20 },
                    { "admin_ID_123456789", 0, "c4c55dd8-cf65-4110-8801-d00747eeb12f", "admin@eventus.com", true, true, null, "admin@eventus.com", "admin@eventus.com", "AQAAAAEAACcQAAAAEDKuqoPPffoJwfh++A4+IODSd+Y11itgPWPwO9RUOrIy+hrHN+PrZ+A1hicGc6/4iw==", null, false, "admin@eventus.com", false, "admin", 0 }
                });

            migrationBuilder.InsertData(
                table: "AspNetUserRoles",
                columns: new[] { "UserId", "RoleId" },
                values: new object[,]
                {
                    { "rt_7000", "1" },
                    { "rt_7018", "1" },
                    { "rt_7017", "1" },
                    { "rt_7016", "1" },
                    { "rt_7015", "1" },
                    { "rt_7014", "1" },
                    { "rt_7013", "1" },
                    { "rt_7012", "1" },
                    { "rt_7011", "1" },
                    { "rt_7019", "1" },
                    { "rt_7010", "1" },
                    { "rt_7008", "1" },
                    { "rt_7007", "1" },
                    { "rt_7006", "1" },
                    { "rt_7005", "1" },
                    { "rt_7004", "1" },
                    { "rt_7003", "1" },
                    { "rt_7002", "1" },
                    { "rt_7001", "1" },
                    { "rt_7009", "1" },
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
                keyValues: new object[] { "rt_7000", "1" });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "UserId", "RoleId" },
                keyValues: new object[] { "rt_7001", "1" });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "UserId", "RoleId" },
                keyValues: new object[] { "rt_7002", "1" });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "UserId", "RoleId" },
                keyValues: new object[] { "rt_7003", "1" });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "UserId", "RoleId" },
                keyValues: new object[] { "rt_7004", "1" });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "UserId", "RoleId" },
                keyValues: new object[] { "rt_7005", "1" });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "UserId", "RoleId" },
                keyValues: new object[] { "rt_7006", "1" });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "UserId", "RoleId" },
                keyValues: new object[] { "rt_7007", "1" });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "UserId", "RoleId" },
                keyValues: new object[] { "rt_7008", "1" });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "UserId", "RoleId" },
                keyValues: new object[] { "rt_7009", "1" });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "UserId", "RoleId" },
                keyValues: new object[] { "rt_7010", "1" });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "UserId", "RoleId" },
                keyValues: new object[] { "rt_7011", "1" });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "UserId", "RoleId" },
                keyValues: new object[] { "rt_7012", "1" });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "UserId", "RoleId" },
                keyValues: new object[] { "rt_7013", "1" });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "UserId", "RoleId" },
                keyValues: new object[] { "rt_7014", "1" });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "UserId", "RoleId" },
                keyValues: new object[] { "rt_7015", "1" });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "UserId", "RoleId" },
                keyValues: new object[] { "rt_7016", "1" });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "UserId", "RoleId" },
                keyValues: new object[] { "rt_7017", "1" });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "UserId", "RoleId" },
                keyValues: new object[] { "rt_7018", "1" });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "UserId", "RoleId" },
                keyValues: new object[] { "rt_7019", "1" });

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
                keyValues: new object[] { "admin_ID_123456789", "c4c55dd8-cf65-4110-8801-d00747eeb12f" });

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumns: new[] { "Id", "ConcurrencyStamp" },
                keyValues: new object[] { "rt_7000", "baddaea9-38b4-4350-be1b-9f2578ce8935" });

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumns: new[] { "Id", "ConcurrencyStamp" },
                keyValues: new object[] { "rt_7001", "ffd39fe7-fb33-4452-9846-59f717fa9628" });

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumns: new[] { "Id", "ConcurrencyStamp" },
                keyValues: new object[] { "rt_7002", "5c082473-0159-43c3-a67a-5d4bc967b63e" });

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumns: new[] { "Id", "ConcurrencyStamp" },
                keyValues: new object[] { "rt_7003", "49975d99-a23f-47e6-85fd-09dc880590ff" });

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumns: new[] { "Id", "ConcurrencyStamp" },
                keyValues: new object[] { "rt_7004", "62ee07a1-8cc6-4de2-90dd-9ef8633974cf" });

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumns: new[] { "Id", "ConcurrencyStamp" },
                keyValues: new object[] { "rt_7005", "f8ad9897-8bec-46a8-9aae-a5bc15ac0b7e" });

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumns: new[] { "Id", "ConcurrencyStamp" },
                keyValues: new object[] { "rt_7006", "48f27f2f-2c22-42f9-8a63-270d7287fa80" });

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumns: new[] { "Id", "ConcurrencyStamp" },
                keyValues: new object[] { "rt_7007", "db8fa27e-488c-4b41-93c3-d860ed88913a" });

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumns: new[] { "Id", "ConcurrencyStamp" },
                keyValues: new object[] { "rt_7008", "b58b6e11-38e7-4c8c-8383-1bbd74fa285f" });

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumns: new[] { "Id", "ConcurrencyStamp" },
                keyValues: new object[] { "rt_7009", "48f6becf-75eb-415d-b6f1-ddd96cb02c35" });

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumns: new[] { "Id", "ConcurrencyStamp" },
                keyValues: new object[] { "rt_7010", "08dce447-5866-4fa7-9085-c97269866786" });

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumns: new[] { "Id", "ConcurrencyStamp" },
                keyValues: new object[] { "rt_7011", "02dc3620-dbd5-4544-8415-991ced8b8b36" });

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumns: new[] { "Id", "ConcurrencyStamp" },
                keyValues: new object[] { "rt_7012", "0163fcd3-42d4-4a02-a678-58754d711bd7" });

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumns: new[] { "Id", "ConcurrencyStamp" },
                keyValues: new object[] { "rt_7013", "aa7640c2-1f91-4da0-84f6-5c215951cf43" });

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumns: new[] { "Id", "ConcurrencyStamp" },
                keyValues: new object[] { "rt_7014", "2be8a42a-c742-4c52-83b1-3777f1f94f10" });

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumns: new[] { "Id", "ConcurrencyStamp" },
                keyValues: new object[] { "rt_7015", "7fe94851-7d7b-4a18-b243-96714fa94ac5" });

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumns: new[] { "Id", "ConcurrencyStamp" },
                keyValues: new object[] { "rt_7016", "d210712c-567a-4f8c-a995-c2458ebf1380" });

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumns: new[] { "Id", "ConcurrencyStamp" },
                keyValues: new object[] { "rt_7017", "a88e3f3b-259c-4018-93ac-723faf5995c3" });

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumns: new[] { "Id", "ConcurrencyStamp" },
                keyValues: new object[] { "rt_7018", "fa102398-c560-40a9-93c7-ae7b2af3c027" });

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumns: new[] { "Id", "ConcurrencyStamp" },
                keyValues: new object[] { "rt_7019", "689b79cc-af5b-41c9-82ad-54c369d20ee9" });
        }
    }
}
