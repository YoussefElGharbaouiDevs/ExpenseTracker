IF OBJECT_ID(N'[__EFMigrationsHistory]') IS NULL
BEGIN
    CREATE TABLE [__EFMigrationsHistory] (
        [MigrationId] nvarchar(150) NOT NULL,
        [ProductVersion] nvarchar(32) NOT NULL,
        CONSTRAINT [PK___EFMigrationsHistory] PRIMARY KEY ([MigrationId])
    );
END;
GO

BEGIN TRANSACTION;
CREATE TABLE [AttachmentType] (
    [Id] int NOT NULL IDENTITY,
    [Name] nvarchar(max) NOT NULL,
    [MaxFileSize] float NOT NULL,
    [CreatedDate] datetime2 NULL,
    [ModifiedDate] datetime2 NULL,
    [CreatedBy] nvarchar(max) NOT NULL,
    [ModifiedBy] nvarchar(max) NOT NULL,
    CONSTRAINT [PK_AttachmentType] PRIMARY KEY ([Id])
);

CREATE TABLE [Category] (
    [Id] int NOT NULL IDENTITY,
    [Name] nvarchar(max) NOT NULL,
    [FileSize] float NOT NULL,
    [CreatedDate] datetime2 NULL,
    [ModifiedDate] datetime2 NULL,
    [CreatedBy] nvarchar(max) NOT NULL,
    [ModifiedBy] nvarchar(max) NOT NULL,
    CONSTRAINT [PK_Category] PRIMARY KEY ([Id])
);

CREATE TABLE [Currency] (
    [Id] int NOT NULL IDENTITY,
    [Name] nvarchar(50) NOT NULL,
    [Abbreviation] nvarchar(3) NOT NULL,
    [Description] nvarchar(max) NOT NULL,
    [CreatedDate] datetime2 NULL,
    [ModifiedDate] datetime2 NULL,
    [CreatedBy] nvarchar(max) NOT NULL,
    [ModifiedBy] nvarchar(max) NOT NULL,
    CONSTRAINT [PK_Currency] PRIMARY KEY ([Id])
);

CREATE TABLE [RecurrenceFrequency] (
    [Id] int NOT NULL IDENTITY,
    [Name] nvarchar(max) NOT NULL,
    [CreatedDate] datetime2 NULL,
    [ModifiedDate] datetime2 NULL,
    [CreatedBy] nvarchar(max) NOT NULL,
    [ModifiedBy] nvarchar(max) NOT NULL,
    CONSTRAINT [PK_RecurrenceFrequency] PRIMARY KEY ([Id])
);

CREATE TABLE [User] (
    [Id] nvarchar(450) NOT NULL,
    [PreferredCurrency] nvarchar(max) NULL,
    [UserName] nvarchar(max) NULL,
    [NormalizedUserName] nvarchar(max) NULL,
    [Email] nvarchar(max) NULL,
    [NormalizedEmail] nvarchar(max) NULL,
    [EmailConfirmed] bit NOT NULL,
    [PasswordHash] nvarchar(max) NULL,
    [SecurityStamp] nvarchar(max) NULL,
    [ConcurrencyStamp] nvarchar(max) NULL,
    [PhoneNumber] nvarchar(max) NULL,
    [PhoneNumberConfirmed] bit NOT NULL,
    [TwoFactorEnabled] bit NOT NULL,
    [LockoutEnd] datetimeoffset NULL,
    [LockoutEnabled] bit NOT NULL,
    [AccessFailedCount] int NOT NULL,
    CONSTRAINT [PK_User] PRIMARY KEY ([Id])
);

CREATE TABLE [Expense] (
    [Id] int NOT NULL IDENTITY,
    [Amount] decimal(18,2) NOT NULL,
    [Date] date NOT NULL,
    [Description] nvarchar(max) NOT NULL,
    [CategoryId] int NOT NULL,
    [IsRecurring] bit NOT NULL,
    [RecurrenceFrequencyId] int NULL,
    [UserId] nvarchar(450) NOT NULL,
    [Currency] nvarchar(max) NOT NULL,
    [CategoryEntityId] int NOT NULL,
    [CreatedDate] datetime2 NULL,
    [ModifiedDate] datetime2 NULL,
    [CreatedBy] nvarchar(max) NOT NULL,
    [ModifiedBy] nvarchar(max) NOT NULL,
    CONSTRAINT [PK_Expense] PRIMARY KEY ([Id]),
    CONSTRAINT [FK_Expense_Category_CategoryEntityId] FOREIGN KEY ([CategoryEntityId]) REFERENCES [Category] ([Id]) ON DELETE CASCADE,
    CONSTRAINT [FK_Expense_RecurrenceFrequency_RecurrenceFrequencyId] FOREIGN KEY ([RecurrenceFrequencyId]) REFERENCES [RecurrenceFrequency] ([Id]),
    CONSTRAINT [FK_Expense_User_UserId] FOREIGN KEY ([UserId]) REFERENCES [User] ([Id]) ON DELETE CASCADE
);

CREATE TABLE [Attachment] (
    [Id] int NOT NULL IDENTITY,
    [Name] nvarchar(max) NOT NULL,
    [OriginalName] nvarchar(max) NOT NULL,
    [Path] nvarchar(max) NOT NULL,
    [FileSize] float NOT NULL,
    [ExpenseId] int NOT NULL,
    [AttachmentTypeId] int NOT NULL,
    [ExpenseEntityId] int NOT NULL,
    [CreatedDate] datetime2 NULL,
    [ModifiedDate] datetime2 NULL,
    [CreatedBy] nvarchar(max) NOT NULL,
    [ModifiedBy] nvarchar(max) NOT NULL,
    CONSTRAINT [PK_Attachment] PRIMARY KEY ([Id]),
    CONSTRAINT [FK_Attachment_AttachmentType_AttachmentTypeId] FOREIGN KEY ([AttachmentTypeId]) REFERENCES [AttachmentType] ([Id]) ON DELETE CASCADE,
    CONSTRAINT [FK_Attachment_Expense_ExpenseEntityId] FOREIGN KEY ([ExpenseEntityId]) REFERENCES [Expense] ([Id]) ON DELETE CASCADE
);

CREATE INDEX [IX_Attachment_AttachmentTypeId] ON [Attachment] ([AttachmentTypeId]);

CREATE INDEX [IX_Attachment_ExpenseEntityId] ON [Attachment] ([ExpenseEntityId]);

CREATE INDEX [IX_Expense_CategoryEntityId] ON [Expense] ([CategoryEntityId]);

CREATE INDEX [IX_Expense_RecurrenceFrequencyId] ON [Expense] ([RecurrenceFrequencyId]);

CREATE INDEX [IX_Expense_UserId] ON [Expense] ([UserId]);

INSERT INTO [__EFMigrationsHistory] ([MigrationId], [ProductVersion])
VALUES (N'20250309024628_Initial', N'9.0.2');

COMMIT;
GO

