ALTER TABLE [dbo].[city] CHECK CONSTRAINT [FK_city_ToTable];
ALTER TABLE [dbo].[gotoStreet] CHECK CONSTRAINT [FK_gotoStreet_ToTable];

-- ALTER TABLE [dbo].[city] NOCHECK CONSTRAINT [FK_city_ToTable];
-- ALTER TABLE [dbo].[gotoStreet] NOCHECK CONSTRAINT [FK_gotoStreet_ToTable];