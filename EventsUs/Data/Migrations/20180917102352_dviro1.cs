using Microsoft.EntityFrameworkCore.Migrations;

namespace EventsUs.Data.Migrations
{
    public partial class dviro1 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<bool>(
                name: "PublicEvent",
                table: "Event",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddColumn<int>(
                name: "adminId",
                table: "Event",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "admin_ID_123456789",
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "f644830b-8412-4c75-a705-1956891e3c8c", "AQAAAAEAACcQAAAAEIm16AqqiKLKIMHZ2JYkPJy9z5wvcQ7wKeFbZL6Db1xFPwsmOXeorMYs6QkoQUzj9Q==" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "Eu_7000",
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "c2aa75a1-984e-409a-a6c9-2d234fc5f79e", "AQAAAAEAACcQAAAAELWhel3CIUycIZ1fycGWmDjn14Y+5d/UpWzAi+PLlFG9RhOyRp9XWI6h/nm5JtUrFQ==" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "Eu_7001",
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "7037b2a0-bd10-4a84-8dc4-09d64d5b10f8", "AQAAAAEAACcQAAAAEAPuCYWgDbjYZlTPADIjjSpwjkNmt03piSW/xfmLPWKk47VzWwtvl8KzpN1Tnl9tRA==" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "Eu_7002",
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "016ebcba-66fe-4b88-ae16-d99048df10b0", "AQAAAAEAACcQAAAAEN/V6UahYFD2gdUVMIz/0M5xosrGQNJPgC1dG1KyANAfRekzbtCpGRH+YxHWIm5uCg==" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "Eu_7003",
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "70f6a895-154d-442a-b878-434a24e643eb", "AQAAAAEAACcQAAAAEKGnbZK4USXZzVfNOoK5rw7Rtwv/t+R1qZ9BqND42rE7VFgzLns9DJeZ+kjLyjynVQ==" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "Eu_7004",
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "ce4cd2af-c21c-44ef-8b5d-758c1165d3d8", "AQAAAAEAACcQAAAAEFEaEgcwjH4OUjj7wvTcHIV7HoNeo6IZkqMZFgUCLpu39+ZW7LWQJqIbeCNXLlX98A==" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "Eu_7005",
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "d761e82d-5147-4f6a-950a-13ed3374416d", "AQAAAAEAACcQAAAAEGsgQvRnzlHaOP6kQA4KDBjfiTtyJy8B76NU5CJXniYsWcvX8g+fRHxB9RWShbjapQ==" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "Eu_7006",
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "3837ebc4-d407-42dc-ba5b-543bc587e593", "AQAAAAEAACcQAAAAEI8Jo0PeaQ26efTvKvTRVzDw4TVkUz42fpHCRTroCzMYluv/gdtNMeLebpWQRg1EiA==" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "Eu_7007",
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "c631a6d2-b423-4133-9202-556cabda1993", "AQAAAAEAACcQAAAAEN7v5YRjiaI/i3xVDkPhbHESWt0kctr2nBLwCcvZS8KzLOvzLkwdNBPRVZOx8ad4wQ==" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "Eu_7008",
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "62e5a136-dccf-42c5-9435-db981b8b1a3b", "AQAAAAEAACcQAAAAEMNh2EOr7JZPG5d4IMKcLq8ZF5lZQ4EueV8KEwlZHGZcDAQO/MyIIxSLKbKs4eeNHA==" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "Eu_7009",
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "406cf7a6-35f9-4b65-bcc4-53192e9b3127", "AQAAAAEAACcQAAAAEO5tkQCK+LXViWARVnLPdpnd/PS8qhCBrc4S/1gqBzuk0CxXyfU12yN1H2899KzAhw==" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "Eu_7010",
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "ca56433f-db65-4df8-8dbe-eef44fe96fb3", "AQAAAAEAACcQAAAAELAdgPdyAMp6p7qrM3gmh40bW3Z0rd+OFLkS7Bnk6kMSkgdVAGMynGKuIT6hA5KcYA==" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "Eu_7011",
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "3d5e146c-82d4-443a-9632-1a5e8f091126", "AQAAAAEAACcQAAAAEHUB8IAM5+DKDD1fye+towLB3uGZ0rTTjHldyqCK63xFIBBARerHGWdgrC6GcN9erw==" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "Eu_7012",
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "ac2af8c4-82c3-4461-a052-f344872d0bd6", "AQAAAAEAACcQAAAAEA8uNfaCJhfbalufa8XnSrZNiOfypuOj0bLkU/lGqZtRdknt6YAjox72Ngmz2mB77w==" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "Eu_7013",
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "5801d9c0-01d1-4fba-afc2-e7f55b4c7e0e", "AQAAAAEAACcQAAAAEAEQNzxoAJzeOZQG/jzlPpWi284wxn+cSAXJGFdin7vTXvyvaJUrYFUU4zyJ30ODEA==" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "Eu_7014",
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "8bebdcdd-821b-4c86-bfd9-e3521dce62bf", "AQAAAAEAACcQAAAAELgDGJykfJ2Vf1oyCenVbbGjeDc9wEyygA49JeSLRrhmKfu6nIgaOUw2BUyxW77x2A==" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "Eu_7015",
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "0a0490b2-35b4-4844-a454-816caeb0dab0", "AQAAAAEAACcQAAAAEI5aKIgClv5sD7g0ivkjYXrLM3ELaOj9MuNT7nRGk+B1cRgyzpgThLCk+gWKKkTTkw==" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "Eu_7016",
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "6a5f88e2-c31f-4af4-87d3-53321f40f5d0", "AQAAAAEAACcQAAAAELJA4fr+xaqgRHBcAKamev1Mu4v4tU0lQ4VmuBs0vDcfCZFCqBSgCEuM860wbGCa1g==" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "Eu_7017",
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "a364351e-e071-4412-ba2c-e76ea6bf6d68", "AQAAAAEAACcQAAAAEFnkFk3Khcmk/F9UP27yaoxyV/BTKTCmJpyO6Va+mtJ8ByB0G5xnkHlyQpRik6lHfQ==" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "Eu_7018",
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "3672d2bb-9768-496b-afea-1e181834fb34", "AQAAAAEAACcQAAAAEGFCzAMpFvI05/ur4TTMbBQbO/b/KVjMxS+zITbsMTQ58cLivJ98+xv639hHSNEOxA==" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "Eu_7019",
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "fd65b970-cf00-4b9b-880d-b559cb7b1de1", "AQAAAAEAACcQAAAAEICCQGrSOK3tomZZPhC57fvQXdUDH/6V2a5gH+Mk9/ujqshpARk5V47uJulFl0P7bA==" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "PublicEvent",
                table: "Event");

            migrationBuilder.DropColumn(
                name: "adminId",
                table: "Event");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "admin_ID_123456789",
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "9d487129-a381-47a3-a895-007d3539827d", "AQAAAAEAACcQAAAAECRct49/c+MzfHdXCJZyymRzQg1cadtdsiIw3km7dUMkZ/8tcd8UVofDvLd3TpKP7g==" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "Eu_7000",
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "bb735e47-dc6a-420c-b773-35b82806a6e4", "AQAAAAEAACcQAAAAEDcLUdcbyYsc1ww89yLRHsURcUpsAsgaPLymAlnbCrtTsReAiaHXp91fWpqtl+r4Ag==" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "Eu_7001",
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "8b7954e6-f18b-4bf9-a984-56a9b631d453", "AQAAAAEAACcQAAAAEHG14C8ziw07ozDsMlUuKu38DO3RlPjLBnnPkvWPNGcOuZyO8Ehwisk9KAbRtGyy8g==" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "Eu_7002",
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "9009515a-e943-42d2-a244-ef9819000901", "AQAAAAEAACcQAAAAEHKAQNM62jo2VGvQkSlj2KB6RoKSbhXCxKx0snt/xL1ZQHirZSXq2w8DkrjToPhX9g==" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "Eu_7003",
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "0899418d-c7c4-4169-983f-37d5e9f9d1c1", "AQAAAAEAACcQAAAAEBpQMPQU0bYmG2vXW4EScsIEcIspmDNH7TNOVzi4wLomGqSSVDeW9lMtkCQAcC7WZg==" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "Eu_7004",
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "986f90ac-e49a-4744-94a7-facd95a8a5de", "AQAAAAEAACcQAAAAEOjEpzCAJBkjiuiuDWSorVhP4ylN9Xv89Z5KZ+tjdc9206Elx+SXIDC/Le22DY/9Hg==" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "Eu_7005",
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "3e513018-2eb2-43fa-ac29-36844264bd4f", "AQAAAAEAACcQAAAAEKAhksfYCnBP8m4lSq/iXVoxJcYonxPt5FTMzBaOBaoiFyzxxDf2tFSohXZleIV/Cw==" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "Eu_7006",
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "99c265bb-fcdf-4047-be51-9983baf26da7", "AQAAAAEAACcQAAAAEPv8ZfFhQ64lwRIwGo9aYGIuYX+l5nk/ALH/VSqjbI8dW38uNDYfxAIa7baOZIgKew==" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "Eu_7007",
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "6477d1c8-b46e-4927-b69b-239f43dc5882", "AQAAAAEAACcQAAAAEIWA9Bqihl8XH9xQxsn02Ot1ELdrXtCchsJ7Tomk6oDKKaVNSOjaC4ONirkQ1yaeKw==" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "Eu_7008",
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "49691df2-882d-44e1-9d7f-73cb4cd1c17f", "AQAAAAEAACcQAAAAEEBzycVYgwDm/xE2Krshw7IUaE0F6a/hN83YKQmL93GusmWy9Cls4IbfBeqHSBblXw==" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "Eu_7009",
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "d9e93f42-c910-4171-b346-f59ec2f7c6bc", "AQAAAAEAACcQAAAAEBA5AbfM98rhta6HvF5Ozf67Nk3ygKyy+Hr16uQUG2sb/9WFLZm7/l3nwAKupyaINw==" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "Eu_7010",
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "98f7ba2a-4352-4929-a6d3-eda658821d1a", "AQAAAAEAACcQAAAAEC+J8LdY4017NdJAZeJR/ovqHYJCjhpNFvg8zIrv+SlX+OmaRp21PAYG7N1uX2xuYQ==" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "Eu_7011",
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "17bbfed4-e83c-45bb-bf4f-3052ac39a1b7", "AQAAAAEAACcQAAAAELRpfVdFJXDlDrp0pP4uWEFzLlgmIjqBIFE4DAwxB8+9xVAj24bN+ATLm66F8Tt9EQ==" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "Eu_7012",
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "5d89dde6-be1a-4527-b055-a941bbd89400", "AQAAAAEAACcQAAAAEG9Hm27QLJV/BgTi179xNFH0xP+lxlI3hXCvCtljgTSHA2D0k/lr/VD38glbQCmqlg==" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "Eu_7013",
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "8321aa16-c75a-4664-a82f-f3eeb045f1e6", "AQAAAAEAACcQAAAAENAhcaAPlZW/gjpo/5qbSly+zQlOD22bS2fb1QfJRKoBcNaClR+w9boDKVb8gX3FZQ==" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "Eu_7014",
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "e1f3efa6-cce7-49a9-add5-8fcf31f26bb1", "AQAAAAEAACcQAAAAEMeQM+Oj87nqGrzgZZxQ0mbfgT9Lf9uKyCMyaO1DaD5hF/JQtjmh/2yyZHISnEG/ww==" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "Eu_7015",
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "f55bddd0-2dd1-48de-b794-500ce2367dc6", "AQAAAAEAACcQAAAAEAPsj53vmD2nve5CNwpTbYqBTN0ANyniMfrPkTRLv/da3kVgP+qWB6liTPtgR4LPCQ==" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "Eu_7016",
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "661d1490-093a-4928-8ecf-508350d7a893", "AQAAAAEAACcQAAAAEBecQiXSNMON8VmrGaQXjjwgjfp03RkSBgBlTvd+j0uEUrl13Z4VVcn75TEwUi2MTw==" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "Eu_7017",
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "68f3fc69-99e1-443c-a5d2-6c3f6a365bae", "AQAAAAEAACcQAAAAEEjXOJUuSwEdVvTN9yBkQ/3td0ZdyBhyCU5cq5iTd1O5GzyhsaEs++44H0Zai5xM7A==" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "Eu_7018",
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "123ae28a-45d7-4f23-a931-ddbe9992a846", "AQAAAAEAACcQAAAAEJHQKeFvjp1BLAxc5FiYO5txdlGH9lr/0tj1nzuxzMx5VIfZLPmqoVl4gkuNx4f3+g==" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "Eu_7019",
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "9c459224-19c3-4378-80fa-f165b8aa5b00", "AQAAAAEAACcQAAAAENoxvAv86sjv5pEy9+L4x+rJTCK9cwbodALA7J+ldlpaaQ7k5gIVY9iVLMYHaOJ4mQ==" });
        }
    }
}
