DECLARE @PackageId NVARCHAR(50) = N'6dd71e6c-0fd6-4f27-bc3e-abb94921b7cf';
DECLARE @Name NVARCHAR(255) = N'SendOrders'
DECLARE @xml NVARCHAR(MAX) = N'<?xml version="1.0" encoding="utf-16"?>
<EtlPackage xmlns:xsi="http://www.w3.org/2001/XMLSchema-instance" xmlns:xsd="http://www.w3.org/2001/XMLSchema">
  <Id>6dd71e6c-0fd6-4f27-bc3e-abb94921b7cf</Id>
  <Name>SendOrders</Name>
  <RunIntervalSeconds>0</RunIntervalSeconds>
  <Enabled>true</Enabled>
  <Variables>
    <Variable>
      <Name>Temp</Name>
      <Modifier>Input</Modifier>
      <DefaultValue>C:\Temp</DefaultValue>
      <Binding>Value</Binding>
      <IsSecure>false</IsSecure>
    </Variable>
    <Variable>
      <Name>EtlYear</Name>
      <Modifier>Bound</Modifier>
      <Binding>EtlSessionYear4</Binding>
      <IsSecure>false</IsSecure>
    </Variable>
    <Variable>
      <Name>EtlMonth</Name>
      <Modifier>Bound</Modifier>
      <Binding>EtlSessionMonth2</Binding>
      <IsSecure>false</IsSecure>
    </Variable>
    <Variable>
      <Name>EtlDay</Name>
      <Modifier>Bound</Modifier>
      <Binding>EtlSessionDay2</Binding>
      <IsSecure>false</IsSecure>
    </Variable>
    <Variable>
      <Name>SessionId</Name>
      <Modifier>Bound</Modifier>
      <Binding>EtlSessionId</Binding>
      <IsSecure>false</IsSecure>
    </Variable>
    <Variable>
      <Name>DB</Name>
      <Modifier>Input</Modifier>
      <DefaultValue>Data Source=.;Initial Catalog=RapidSoft.VTB24.BankConnector;Integrated Security=True</DefaultValue>
      <Binding>Value</Binding>
      <IsSecure>false</IsSecure>
    </Variable>
    <Variable>
      <Name>SmtpHost</Name>
      <Modifier>Input</Modifier>
      <DefaultValue>notset</DefaultValue>
      <Binding>None</Binding>
      <IsSecure>false</IsSecure>
    </Variable>
    <Variable>
      <Name>SmtpPort</Name>
      <Modifier>Input</Modifier>
      <Binding>None</Binding>
      <DefaultValue>notset</DefaultValue>
      <IsSecure>false</IsSecure>
    </Variable>
    <Variable>
      <Name>SmtpUseSSL</Name>
      <Modifier>Input</Modifier>
      <Binding>None</Binding>
      <DefaultValue>notset</DefaultValue>
      <IsSecure>false</IsSecure>
    </Variable>
    <Variable>
      <Name>SmtpUserName</Name>
      <Modifier>Input</Modifier>
      <Binding>None</Binding>
      <DefaultValue>notset</DefaultValue>
      <IsSecure>false</IsSecure>
    </Variable>
    <Variable>
      <Name>SmtpPassword</Name>
      <Modifier>Input</Modifier>
      <Binding>None</Binding>
      <DefaultValue>notset</DefaultValue>
      <IsSecure>false</IsSecure>
    </Variable>
    <Variable>
      <Name>MailToTeradataFrom</Name>
      <Modifier>Input</Modifier>
      <Binding>None</Binding>
      <DefaultValue>notset</DefaultValue>
      <IsSecure>false</IsSecure>
    </Variable>
    <Variable>
      <Name>MailToTeradataTo</Name>
      <Modifier>Input</Modifier>
      <Binding>None</Binding>
      <DefaultValue>notset</DefaultValue>
      <IsSecure>false</IsSecure>
    </Variable>
    <Variable>
      <Name>BatchSize</Name>
      <Modifier>Input</Modifier>
      <DefaultValue>notset</DefaultValue>
      <Binding>None</Binding>
      <IsSecure>false</IsSecure>
    </Variable>
  </Variables>
  <Steps>
    <InvokeMethod>
      <Name>�������� ������������ ������</Name>
      <TimeoutMilliseconds xsi:nil="true" />
      <Source>
        <Name>assembly</Name>
        <AssemblyName>RapidSoft.VTB24.BankConnector</AssemblyName>
        <TypeName>RapidSoft.VTB24.BankConnector.EtlInvokeHelper</TypeName>
        <MethodName>SaveOrdersForPayment</MethodName>
        <Parameters>
          <EtlMethodParameter>
            <Name>targetFolder</Name>
            <Value>$(Temp)\VTB_$(SessionId)\</Value>
          </EtlMethodParameter>
        </Parameters>
      </Source>
    </InvokeMethod>
    <ExportCsvFile>
      <Name>��������� ���������� ������ � ����</Name>
      <TimeoutMilliseconds xsi:nil="true" />
      <EndSessionOnEmptySource>true</EndSessionOnEmptySource>
      <Source>
        <Name>Database</Name>
        <ConnectionString>$(DB)</ConnectionString>
        <ProviderName>System.Data.SqlClient</ProviderName>
        <Text>
          SELECT
          [OrderId]
          ,[OrderItemId]
          ,[PartnerId]
          ,[PartnerOrderNum]
          ,[ClientId]
          ,[ArticleId]
          ,[ArticleName]
          ,[Amount]
          ,[OrderBonusCost]
          ,[OrderTotalCost]
          ,CONVERT(VARCHAR(19), [OrderDateTime], 126) AS OrderDateTime
          ,[POSId]
          ,[DeliveryRegion]
          ,[DeliveryCity]
          ,[DeliveryAddress]
          ,[ContactName]
          ,SUBSTRING([ContactPhone], 2, LEN([ContactPhone])) AS [ContactPhone]
          ,[ContactEmail]
          ,[Advance]
          ,[AdvancePOSId]
          ,[AdvanceRRN]
          FROM [dbo].[OrderItemsForPayment]  WHERE   [EtlSessionId] = @sessionId
        </Text>
        <Parameters>
          <EtlQueryParameter>
            <Name>sessionId</Name>
            <Value>$(SessionId)</Value>
          </EtlQueryParameter>
        </Parameters>
      </Source>
      <Destination>
        <Name>Temp folder</Name>
        <FilePath>$(Temp)\VTB_$(SessionId)\VTB_$(EtlYear)$(EtlMonth)$(EtlDay)_@count.orderPL</FilePath>
        <CodePage>1251</CodePage>
        <HasHeaders>true</HasHeaders>
        <FieldDelimiter>;</FieldDelimiter>
        <FileCounterDbStorage>
          <ConnectionString>$(DB)</ConnectionString>
          <SchemaName>etl</SchemaName>
          <BatchSize>$(BatchSize)</BatchSize>
          <BatchCounterTag>@count</BatchCounterTag>
        </FileCounterDbStorage>
      </Destination>
      <Mappings>
        <Mapping>
          <SourceFieldName>OrderId</SourceFieldName>
          <DestinationFieldName>OrderId</DestinationFieldName>
        </Mapping>
        <Mapping>
          <SourceFieldName>OrderItemId</SourceFieldName>
          <DestinationFieldName>OrderItemId</DestinationFieldName>
        </Mapping>
        <Mapping>
          <SourceFieldName>PartnerId</SourceFieldName>
          <DestinationFieldName>PartnerId</DestinationFieldName>
        </Mapping>
        <Mapping>
          <SourceFieldName>PartnerOrderNum</SourceFieldName>
          <DestinationFieldName>PartnerOrderNum</DestinationFieldName>
        </Mapping>
        <Mapping>
          <SourceFieldName>ClientId</SourceFieldName>
          <DestinationFieldName>ClientId</DestinationFieldName>
        </Mapping>
        <Mapping>
          <SourceFieldName>ArticleId</SourceFieldName>
          <DestinationFieldName>ArticleId</DestinationFieldName>
        </Mapping>
        <Mapping>
          <SourceFieldName>ArticleName</SourceFieldName>
          <DestinationFieldName>ArticleName</DestinationFieldName>
          <SourceFieldTranslation>
            <Functions>
              <ReplaceHtmlEntities />
            </Functions>
          </SourceFieldTranslation>
        </Mapping>
        <Mapping>
          <SourceFieldName>Amount</SourceFieldName>
          <DestinationFieldName>Amount</DestinationFieldName>
        </Mapping>
        <Mapping>
          <SourceFieldName>OrderBonusCost</SourceFieldName>
          <DestinationFieldName>OrderBonusCost</DestinationFieldName>
        </Mapping>
        <Mapping>
          <SourceFieldName>OrderTotalCost</SourceFieldName>
          <DestinationFieldName>OrderTotalCost</DestinationFieldName>
        </Mapping>
        <Mapping>
          <SourceFieldName>OrderDateTime</SourceFieldName>
          <DestinationFieldName>OrderDateTime</DestinationFieldName>
        </Mapping>
        <Mapping>
          <SourceFieldName>POSId</SourceFieldName>
          <DestinationFieldName>POSId</DestinationFieldName>
        </Mapping>
        <Mapping>
          <SourceFieldName>DeliveryRegion</SourceFieldName>
          <DestinationFieldName>DeliveryRegion</DestinationFieldName>
          <SourceFieldTranslation>
            <Functions>
              <ReplaceHtmlEntities />
            </Functions>
          </SourceFieldTranslation>
        </Mapping>
        <Mapping>
          <SourceFieldName>DeliveryCity</SourceFieldName>
          <DestinationFieldName>DeliveryCity</DestinationFieldName>
          <SourceFieldTranslation>
            <Functions>
              <ReplaceHtmlEntities />
            </Functions>
          </SourceFieldTranslation>
        </Mapping>
        <Mapping>
          <SourceFieldName>DeliveryAddress</SourceFieldName>
          <DestinationFieldName>DeliveryAddress</DestinationFieldName>
          <SourceFieldTranslation>
            <Functions>
              <ReplaceHtmlEntities />
            </Functions>
          </SourceFieldTranslation>
        </Mapping>
        <Mapping>
          <SourceFieldName>ContactName</SourceFieldName>
          <DestinationFieldName>ContactName</DestinationFieldName>
          <SourceFieldTranslation>
            <Functions>
              <ReplaceHtmlEntities />
            </Functions>
          </SourceFieldTranslation>
        </Mapping>
        <Mapping>
          <SourceFieldName>ContactPhone</SourceFieldName>
          <DestinationFieldName>ContactPhone</DestinationFieldName>
        </Mapping>
        <Mapping>
          <SourceFieldName>ContactEmail</SourceFieldName>
          <DestinationFieldName>ContactEmail</DestinationFieldName>
          <SourceFieldTranslation>
            <Functions>
              <ReplaceHtmlEntities />
            </Functions>
          </SourceFieldTranslation>
        </Mapping>
        <Mapping>
          <SourceFieldName>Advance</SourceFieldName>
          <DestinationFieldName>Advance</DestinationFieldName>
        </Mapping>
        <Mapping>
          <SourceFieldName>AdvancePOSId</SourceFieldName>
          <DestinationFieldName>AdvancePOSId</DestinationFieldName>
        </Mapping>
        <Mapping>
          <SourceFieldName>AdvanceRRN</SourceFieldName>
          <DestinationFieldName>AdvanceRRN</DestinationFieldName>
        </Mapping>
      </Mappings>
    </ExportCsvFile>
    <Encrypt>
      <Name>���������� ������</Name>
      <TimeoutMilliseconds xsi:nil="true" />
      <WorkingDirectory>$(Temp)\VTB_$(SessionId)</WorkingDirectory>
    </Encrypt>
    <EmailSend>
      <Name>�������� �����</Name>
      <TimeoutMilliseconds xsi:nil="true" />
      <Source>
        <Name>����</Name>
        <FilePath>$(Temp)\VTB_$(SessionId)\</FilePath>
        <CodePage>1251</CodePage>
      </Source>
      <EmailServer>
        <Host>$(SmtpHost)</Host>
        <Port>$(SmtpPort)</Port>
        <UseSSL>$(SmtpUseSSL)</UseSSL>
        <UserName>$(SmtpUserName)</UserName>
        <Password>$(SmtpPassword)</Password>
      </EmailServer>
      <EmailDbStorage>
        <ConnectionString>$(DB)</ConnectionString>
        <SchemaName>etl</SchemaName>
      </EmailDbStorage>
      <Message>
        <From>$(MailToTeradataFrom)</From>
        <To><string>$(MailToTeradataTo)</string></To>
        <Subject>Orders_Request_$(EtlYear)_$(EtlMonth)_$(EtlDay)</Subject>
        <AttachmentFileMask>VTB_*.orderPL</AttachmentFileMask>
      </Message>
    </EmailSend>
  </Steps>
</EtlPackage>
'

IF NOT EXISTS(SELECT 1 FROM [etl].[EtlPackages] WHERE Id = @PackageId)
        INSERT [etl].[EtlPackages] ([Id], [Name], [Text], [RunIntervalSeconds], [Enabled])
        VALUES (@PackageId, @Name, @xml, 0, 1)
ELSE
        UPDATE [etl].[EtlPackages] SET [Text]=@xml,[Name]=@Name
        WHERE [Id] = @PackageId
