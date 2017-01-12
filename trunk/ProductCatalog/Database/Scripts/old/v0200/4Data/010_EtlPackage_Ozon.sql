DELETE FROM [dbo].[EtlPackages]
WHERE [Id] = N'777ff1a8-3fbf-4127-96d3-70a0fa7fd05c'

INSERT [dbo].[EtlPackages] ([Id], [Name], [Text], [RunIntervalSeconds], [Enabled]) 
VALUES (N'777ff1a8-3fbf-4127-96d3-70a0fa7fd05c', N'������ ��������� �������� �����', N'<?xml version="1.0" encoding="utf-16"?>
<EtlPackage xmlns:xsi="http://www.w3.org/2001/XMLSchema-instance" xmlns:xsd="http://www.w3.org/2001/XMLSchema">
  <Id>777ff1a8-3fbf-4127-96d3-70a0fa7fd05c</Id>
  <Name>������ ��������� ��������</Name>
  <RunIntervalSeconds>0</RunIntervalSeconds>
  <Enabled>true</Enabled>
  <Variables>
    <Variable>
      <Name>EtlSessionId</Name>
      <Modifier>Bound</Modifier>
      <Binding>EtlSessionId</Binding>
      <IsSecure>false</IsSecure>
    </Variable>
    <Variable>
      <Name>EtlPackageId</Name>
      <Modifier>Bound</Modifier>
      <Binding>EtlPackageId</Binding>
      <IsSecure>false</IsSecure>
    </Variable>
    <Variable>
      <Name>DB</Name>
      <Modifier>Input</Modifier>
      <DefaultValue></DefaultValue>
      <Binding>Value</Binding>
      <IsSecure>false</IsSecure>
    </Variable>
    <Variable>
      <Name>FileUrl</Name>
      <Modifier>Input</Modifier>
      <DefaultValue></DefaultValue>
      <Binding>Value</Binding>
      <IsSecure>false</IsSecure>
    </Variable>
    <Variable>
      <Name>TempDir</Name>
      <Modifier>Input</Modifier>
      <DefaultValue>C:\Temp</DefaultValue>
      <Binding>Value</Binding>
      <IsSecure>false</IsSecure>
    </Variable>
    <Variable>
      <Name>PartnerId</Name>
      <Modifier>Input</Modifier>
      <DefaultValue></DefaultValue>
      <Binding>None</Binding>
      <IsSecure>false</IsSecure>
    </Variable>
  </Variables>
  <Steps>
  
    <DownloadFile>
      <Name>�������� ����� � ��������</Name>
      <TimeoutMilliseconds xsi:nil="true" />
      <Source>
        <Name>HTTP</Name>
        <Uri>$(FileUrl)</Uri>
        <AllowInvalidCertificates>false</AllowInvalidCertificates>
        <Method>GET</Method>
        <Headers />
      </Source>
      <Destination>
        <Name>��������� ����������</Name>
        <FilePath>$(TempDir)/$(EtlSessionId).csv</FilePath>
        <CodePage>65001</CodePage>
      </Destination>
    </DownloadFile>
	
    <ImportCsvFile>
      <Name>������ CSV-����� � �������� �������</Name>
      <TimeoutMilliseconds xsi:nil="true" />
      <Source>
        <Name>��������� ����������</Name>
        <FilePath>$(TempDir)/$(EtlSessionId).csv</FilePath>
        <CodePage>65001</CodePage>
        <HasHeaders>true</HasHeaders>
        <FieldDelimiter>;</FieldDelimiter>
      </Source>
      <Destination>
        <Name>�������� �������</Name>
        <ConnectionString>$(DB)</ConnectionString>
        <ProviderName>System.Data.SqlClient</ProviderName>
        <TableName>prod.BUFFER_DeliveryRates_Ozon</TableName>
      </Destination>
      <BatchSize>0</BatchSize>
      <Mappings>
        <Mapping>
          <DestinationFieldName>EtlSessionId</DestinationFieldName>
          <DefaultValue>$(EtlSessionId)</DefaultValue>
        </Mapping>
        <Mapping>
          <SourceFieldName>������������� ������</SourceFieldName>
          <DestinationFieldName>CityId</DestinationFieldName>
          <DefaultValue>-</DefaultValue>
        </Mapping>
        <Mapping>
          <SourceFieldName>�������</SourceFieldName>
          <DestinationFieldName>Region</DestinationFieldName>
          <DefaultValue>-</DefaultValue>
        </Mapping>
        <Mapping>
          <SourceFieldName>�����</SourceFieldName>
          <DestinationFieldName>City</DestinationFieldName>
          <DefaultValue>-</DefaultValue>
        </Mapping>
        <Mapping>
          <SourceFieldName>����������� ��c</SourceFieldName>
          <DestinationFieldName>MinWeightGram</DestinationFieldName>
        </Mapping>
        <Mapping>
          <SourceFieldName>������������ ���</SourceFieldName>
          <DestinationFieldName>MaxWeightGram</DestinationFieldName>
        </Mapping>
        <Mapping>
          <SourceFieldName>���������</SourceFieldName>
          <DestinationFieldName>PriceRur</DestinationFieldName>
        </Mapping>
      </Mappings>
      <DataLossBehavior>Fail</DataLossBehavior>
    </ImportCsvFile>
	
    <ExecuteProcedure>
      <Name>���������� ��������� ���������� ������� ��� �����</Name>
      <TimeoutMilliseconds xsi:nil="true" />
      <Source>
        <Name>prod.ImportDeliveryRates</Name>
        <ConnectionString>$(DB)</ConnectionString>
        <ProviderName>System.Data.SqlClient</ProviderName>
        <ProcedureName>prod.PreImportDeliveryRatesOzon</ProcedureName>
        <Parameters>
          <Parameter>
            <Name>EtlPackageId</Name>
            <Value>$(EtlPackageId)</Value>
          </Parameter>
          <Parameter>
            <Name>EtlSessionId</Name>
            <Value>$(EtlSessionId)</Value>
          </Parameter>
        </Parameters>
      </Source>
    </ExecuteProcedure>
	
    <ExecuteProcedure>
      <Name>���������� ��������� �������</Name>
      <TimeoutMilliseconds xsi:nil="true" />
      <Source>
        <Name>prod.ImportDeliveryRates</Name>
        <ConnectionString>$(DB)</ConnectionString>
        <ProviderName>System.Data.SqlClient</ProviderName>
        <ProcedureName>prod.ImportDeliveryRates</ProcedureName>
        <Parameters>
          <Parameter>
            <Name>EtlPackageId</Name>
            <Value>$(EtlPackageId)</Value>
          </Parameter>
          <Parameter>
            <Name>EtlSessionId</Name>
            <Value>$(EtlSessionId)</Value>
          </Parameter>
          <Parameter>
            <Name>PartnerId</Name>
            <Value>$(PartnerId)</Value>
          </Parameter>
        </Parameters>
      </Source>
    </ExecuteProcedure>
	
  </Steps>
</EtlPackage>', 0, 1)
GO


