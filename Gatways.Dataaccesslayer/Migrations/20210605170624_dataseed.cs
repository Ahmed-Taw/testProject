using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace Gatways.Dataaccesslayer.Migrations
{
    public partial class dataseed : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "Gateways",
                columns: new[] { "Id", "IP4", "Name" },
                values: new object[,]
                {
                    { "Test-gateway-1", "192.158.1.38", "Gate-1" },
                    { "Test-gateway-2", "192.158.1.100", " Gate-2" },
                    { "Test-gateway-3", "192.158.1.50", "Gate-3" }
                });

            migrationBuilder.InsertData(
                table: "PeripheralDeviceStatus",
                columns: new[] { "Id", "Description" },
                values: new object[,]
                {
                    { 1, "OnLine" },
                    { 2, "OffLine" }
                });

            migrationBuilder.InsertData(
                table: "PeripheralDevices",
                columns: new[] { "Id", "CreatedDate", "GatewayId", "StatusId", "Vendor" },
                values: new object[,]
                {
                    { 1, new DateTime(2021, 6, 5, 17, 6, 23, 866, DateTimeKind.Utc).AddTicks(8011), "Test-gateway-1", 1, "Gate1-1" },
                    { 2, new DateTime(2021, 6, 5, 17, 6, 23, 867, DateTimeKind.Utc).AddTicks(306), "Test-gateway-1", 1, " Gate1-2" },
                    { 3, new DateTime(2021, 6, 5, 17, 6, 23, 867, DateTimeKind.Utc).AddTicks(351), "Test-gateway-1", 1, "Gate1-3" },
                    { 4, new DateTime(2021, 6, 5, 17, 6, 23, 867, DateTimeKind.Utc).AddTicks(354), "Test-gateway-1", 1, "Gate1-4" },
                    { 5, new DateTime(2021, 6, 5, 17, 6, 23, 867, DateTimeKind.Utc).AddTicks(356), "Test-gateway-1", 1, " Gate1-5" },
                    { 8, new DateTime(2021, 6, 5, 17, 6, 23, 867, DateTimeKind.Utc).AddTicks(361), "Test-gateway-1", 1, "Gate1-8" },
                    { 9, new DateTime(2021, 6, 5, 17, 6, 23, 867, DateTimeKind.Utc).AddTicks(362), "Test-gateway-1", 1, " Gate1-9" },
                    { 10, new DateTime(2021, 6, 5, 17, 6, 23, 867, DateTimeKind.Utc).AddTicks(364), "Test-gateway-1", 1, "Gate1-10" },
                    { 11, new DateTime(2021, 6, 5, 17, 6, 23, 867, DateTimeKind.Utc).AddTicks(365), "Test-gateway-2", 1, "Gate1-8" },
                    { 13, new DateTime(2021, 6, 5, 17, 6, 23, 867, DateTimeKind.Utc).AddTicks(369), "Test-gateway-2", 1, "Gate1-10" },
                    { 14, new DateTime(2021, 6, 5, 17, 6, 23, 867, DateTimeKind.Utc).AddTicks(370), "Test-gateway-3", 1, "Gate1-8" },
                    { 6, new DateTime(2021, 6, 5, 17, 6, 23, 867, DateTimeKind.Utc).AddTicks(358), "Test-gateway-1", 2, "Gate1-6" },
                    { 7, new DateTime(2021, 6, 5, 17, 6, 23, 867, DateTimeKind.Utc).AddTicks(359), "Test-gateway-1", 2, "Gate1-7" },
                    { 12, new DateTime(2021, 6, 5, 17, 6, 23, 867, DateTimeKind.Utc).AddTicks(367), "Test-gateway-2", 2, " Gate1-9" }
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "PeripheralDevices",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "PeripheralDevices",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "PeripheralDevices",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "PeripheralDevices",
                keyColumn: "Id",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "PeripheralDevices",
                keyColumn: "Id",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "PeripheralDevices",
                keyColumn: "Id",
                keyValue: 6);

            migrationBuilder.DeleteData(
                table: "PeripheralDevices",
                keyColumn: "Id",
                keyValue: 7);

            migrationBuilder.DeleteData(
                table: "PeripheralDevices",
                keyColumn: "Id",
                keyValue: 8);

            migrationBuilder.DeleteData(
                table: "PeripheralDevices",
                keyColumn: "Id",
                keyValue: 9);

            migrationBuilder.DeleteData(
                table: "PeripheralDevices",
                keyColumn: "Id",
                keyValue: 10);

            migrationBuilder.DeleteData(
                table: "PeripheralDevices",
                keyColumn: "Id",
                keyValue: 11);

            migrationBuilder.DeleteData(
                table: "PeripheralDevices",
                keyColumn: "Id",
                keyValue: 12);

            migrationBuilder.DeleteData(
                table: "PeripheralDevices",
                keyColumn: "Id",
                keyValue: 13);

            migrationBuilder.DeleteData(
                table: "PeripheralDevices",
                keyColumn: "Id",
                keyValue: 14);

            migrationBuilder.DeleteData(
                table: "Gateways",
                keyColumn: "Id",
                keyValue: "Test-gateway-1");

            migrationBuilder.DeleteData(
                table: "Gateways",
                keyColumn: "Id",
                keyValue: "Test-gateway-2");

            migrationBuilder.DeleteData(
                table: "Gateways",
                keyColumn: "Id",
                keyValue: "Test-gateway-3");

            migrationBuilder.DeleteData(
                table: "PeripheralDeviceStatus",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "PeripheralDeviceStatus",
                keyColumn: "Id",
                keyValue: 2);
        }
    }
}
