DELETE FROM [etl].[EtlVariables] WHERE EtlPackageId='051CECFE-32EA-4739-BDC1-458BC36DE7B1'
GO
DELETE FROM [etl].[EtlMessages] WHERE EtlPackageId='051CECFE-32EA-4739-BDC1-458BC36DE7B1'
GO

update [etl].[EtlSessions]
set [EtlPackageId]='C137A6C9-059E-4323-BBD5-000FC754457A'
where EtlPackageId='051CECFE-32EA-4739-BDC1-458BC36DE7B1'
GO

DELETE FROM [etl].EtlSessions WHERE EtlPackageId='051CECFE-32EA-4739-BDC1-458BC36DE7B1'
GO
delete from [etl].[EtlPackages] WHERE [Id] = '051CECFE-32EA-4739-BDC1-458BC36DE7B1'
GO