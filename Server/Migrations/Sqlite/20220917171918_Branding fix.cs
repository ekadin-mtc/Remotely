﻿using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Remotely.Server.Migrations.Sqlite;

public partial class Brandingfix : Migration
{
    protected override void Up(MigrationBuilder migrationBuilder)
    {
        migrationBuilder.DropForeignKey(
            name: "FK_Organizations_BrandingInfo_BrandingInfoId",
            table: "Organizations");

        migrationBuilder.DropIndex(
            name: "IX_Organizations_BrandingInfoId",
            table: "Organizations");

        migrationBuilder.DropPrimaryKey(
            name: "PK_BrandingInfo",
            table: "BrandingInfo");

        migrationBuilder.DropColumn(
            name: "BrandingInfoId",
            table: "Organizations");

        migrationBuilder.RenameTable(
            name: "BrandingInfo",
            newName: "BrandingInfos");

        migrationBuilder.AlterColumn<string>(
            name: "Product",
            table: "BrandingInfos",
            type: "TEXT",
            maxLength: 25,
            nullable: false,
            defaultValue: "",
            oldClrType: typeof(string),
            oldType: "TEXT",
            oldMaxLength: 25,
            oldNullable: true);

        migrationBuilder.AlterColumn<byte[]>(
            name: "Icon",
            table: "BrandingInfos",
            type: "BLOB",
            nullable: false,
            defaultValue: new byte[0],
            oldClrType: typeof(byte[]),
            oldType: "BLOB",
            oldNullable: true);

        migrationBuilder.AddColumn<string>(
            name: "OrganizationId",
            table: "BrandingInfos",
            type: "TEXT",
            nullable: true);

        migrationBuilder.AddPrimaryKey(
            name: "PK_BrandingInfos",
            table: "BrandingInfos",
            column: "Id");

        migrationBuilder.CreateIndex(
            name: "IX_BrandingInfos_OrganizationId",
            table: "BrandingInfos",
            column: "OrganizationId",
            unique: true);

        migrationBuilder.AddForeignKey(
            name: "FK_BrandingInfos_Organizations_OrganizationId",
            table: "BrandingInfos",
            column: "OrganizationId",
            principalTable: "Organizations",
            principalColumn: "ID");
    }

    protected override void Down(MigrationBuilder migrationBuilder)
    {
        migrationBuilder.DropForeignKey(
            name: "FK_BrandingInfos_Organizations_OrganizationId",
            table: "BrandingInfos");

        migrationBuilder.DropPrimaryKey(
            name: "PK_BrandingInfos",
            table: "BrandingInfos");

        migrationBuilder.DropIndex(
            name: "IX_BrandingInfos_OrganizationId",
            table: "BrandingInfos");

        migrationBuilder.DropColumn(
            name: "OrganizationId",
            table: "BrandingInfos");

        migrationBuilder.RenameTable(
            name: "BrandingInfos",
            newName: "BrandingInfo");

        migrationBuilder.AddColumn<string>(
            name: "BrandingInfoId",
            table: "Organizations",
            type: "TEXT",
            nullable: true);

        migrationBuilder.AlterColumn<string>(
            name: "Product",
            table: "BrandingInfo",
            type: "TEXT",
            maxLength: 25,
            nullable: true,
            oldClrType: typeof(string),
            oldType: "TEXT",
            oldMaxLength: 25);

        migrationBuilder.AlterColumn<byte[]>(
            name: "Icon",
            table: "BrandingInfo",
            type: "BLOB",
            nullable: true,
            oldClrType: typeof(byte[]),
            oldType: "BLOB");

        migrationBuilder.AddPrimaryKey(
            name: "PK_BrandingInfo",
            table: "BrandingInfo",
            column: "Id");

        migrationBuilder.CreateIndex(
            name: "IX_Organizations_BrandingInfoId",
            table: "Organizations",
            column: "BrandingInfoId");

        migrationBuilder.AddForeignKey(
            name: "FK_Organizations_BrandingInfo_BrandingInfoId",
            table: "Organizations",
            column: "BrandingInfoId",
            principalTable: "BrandingInfo",
            principalColumn: "Id");
    }
}
