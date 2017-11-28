# EdiEngine
Simple .NET EDI Reader, Writer and Validator.
Read, Write and Validate X12 EDI files with simple EDI Parser written on C#.
Supports EDI to JSON / XML and JSON / XML to EDI conversion (uses Newtonsoft Json).
Supports configurable EDI 997 - Functional Acknowledgment generation.
Maps repository contains all 004010 maps, including Purchase Order, Invoice and many others.
You can easily craft yours on their basis.

### Installation
Install Nuget Package
```
Install-Package xEdi.EdiEngine
```
### Reading EDI and Writing JSON or XML 
```cs
string edi =
@"ISA*01*0000000000*01*0000000000*ZZ*ABCDEFGHIJKLMNO*ZZ*123456789012345*101127*1719*U*00400*000003438*0*P*>
GS*OW*7705551212*3111350000*20000128*0557*3317*T*004010
ST*940*0001
W05*N*538686**001001*538686
LX*1
W01*12*CA*000100000010*VN*000100*UC*DEC0199******19991205
G69*11.500 STRUD BLUBRY
W76*56*500*LB*24*CF
SE*7*0001
GE*1*3317
IEA*1*000003438";

EdiDataReader r = new EdiDataReader();
EdiBatch b = r.FromString(edi);

//whole EDI file with all envelopes, groups and messages
string jsonBatch = JsonConvert.SerializeObject(b);
//selected messages
string jsonTrans = JsonConvert.SerializeObject(b.Interchanges[0].Groups[0].Transactions[0]);

//Serialize batch to XML
XmlDataWriter w = new XmlDataWriter();
string xmlBatch = w.WriteToString(b);
```
### Reading JSON
```cs
string json = @"{
    'Type': 'M',
    'Name': 'M_940',
    'Content': [{
        'Type': 'S',
        'Name': 'W05',
        'Content': [ { 'E': 'N' }, { 'E': '538686' }, { 'E': '' }, { 'E': '001001' }, { 'E': '538686' }]
    }]
}";
M_940 map = new M_940();
JsonMapReader r = new JsonMapReader(map);
EdiTrans t = r.ReadToEnd(json);
```
### Reading XML example
```cs
string xml = @"<EdiTrans>
        <Name>M_940</Name>
        <Content>
            <EdiSegment>
                <Name>W05</Name>
                <Content>
                    <E>N</E>
                    <E>538686</E>
                    <E />
                    <E>001001</E>
                    <E>538686</E>
                </Content>
            </EdiSegment>
        </Content>
    </EdiTrans>";
M_940 map = new M_940();
XmlMapReader r = new XmlMapReader(map);
EdiTrans t = r.ReadToEnd(xml);
```
### Writing complete EDI Envelope with one message- Console App
```cs
using System;
using EdiEngine.Standards.X12_004010.Maps;
using System.Linq;
using EdiEngine;
using EdiEngine.Common.Definitions;
using EdiEngine.Runtime;
using SegmentDefinitions =EdiEngine.Standards.X12_004010.Segments;

namespace ConsoleApplication1
{
    class Program
    {
        static void Main()
        {
            M_940 map = new M_940();
            EdiTrans t = new EdiTrans(map);

            // W05
            var sDef = (MapSegment)map.Content.First(s => s.Name == "W05");

            var seg = new EdiSegment(sDef);
            seg.Content.AddRange(new[] {
                new EdiDataElement(sDef.Content[0], "N"),
                new EdiDataElement(sDef.Content[1], "538686"),
                new EdiDataElement(sDef.Content[2], null),
                new EdiDataElement(sDef.Content[3], "001001"),
                new EdiDataElement(sDef.Content[4], "538686")
            });

            t.Content.Add(seg);

            var g = new EdiGroup("OW");
            g.Transactions.Add(t);

            var i = new EdiInterchange()
            {
                ElementSeparator = "*",
                SegmentSeparator = "\r\n"
            };
            i.Groups.Add(g);

            EdiBatch b = new EdiBatch();
            b.Interchanges.Add(i);

            //Add all service segments
            EdiDataWriterSettings settings = new EdiDataWriterSettings(
                new SegmentDefinitions.ISA(), new SegmentDefinitions.IEA(),
                new SegmentDefinitions.GS(), new SegmentDefinitions.GE(),
                new SegmentDefinitions.ST(), new SegmentDefinitions.SE(),
                "ZZ", "SENDER", "ZZ", "RECEIVER", "GSSENDER", "GSRECEIVER",
                "00401", "004010", "T", 100, 200, "\r\n", "*");

            EdiDataWriter w = new EdiDataWriter(settings);
            Console.WriteLine(w.WriteToString(b));
            Console.Read();
        }
    }
}
```
### EDI X12 Map Example
```cs
//Map
public M_940() : base(null)
{
    Content.AddRange(new MapBaseEntity[] {
        new W05() { ReqDes = RequirementDesignator.Mandatory, MaxOccurs = 1 },
        new L_N1(this) { ReqDes = RequirementDesignator.Optional, MaxOccurs = 10 },
        new N9() { ReqDes = RequirementDesignator.Optional, MaxOccurs = 10 },
        new G61() { ReqDes = RequirementDesignator.Optional, MaxOccurs = 3 },
        new G62() { ReqDes = RequirementDesignator.Optional, MaxOccurs = 10 },
        new NTE() { ReqDes = RequirementDesignator.Optional, MaxOccurs = 999999 },
        new W09() { ReqDes = RequirementDesignator.Optional, MaxOccurs = 1 },
        new W66() { ReqDes = RequirementDesignator.Optional, MaxOccurs = 1 },
        new W6() { ReqDes = RequirementDesignator.Optional, MaxOccurs = 1 },
        new R2() { ReqDes = RequirementDesignator.Optional, MaxOccurs = 13 },
        new BNX() { ReqDes = RequirementDesignator.Optional, MaxOccurs = 1 },
        new L_LM(this) { ReqDes = RequirementDesignator.Optional, MaxOccurs = 10 },
        new L_LX(this) { ReqDes = RequirementDesignator.Optional, MaxOccurs = 999999 },
        new W76() { ReqDes = RequirementDesignator.Optional, MaxOccurs = 1 },
    });
}
//Segment
public class W05 : MapSegment
{
    public W05()
    {
        Content.AddRange(new MapDataElement[] {
            new E_0473 { ReqDes = RequirementDesignator.Mandatory  },
            new E_0285 { ReqDes = RequirementDesignator.Mandatory  },
            new E_0324 { ReqDes = RequirementDesignator.Optional  },
            new E_0472 { ReqDes = RequirementDesignator.Optional  },
            new E_0474 { ReqDes = RequirementDesignator.Optional  },
            new E_0640 { ReqDes = RequirementDesignator.Optional  },
            new E_0306 { ReqDes = RequirementDesignator.Optional  },
        });
    }
}
//DataElement
public class E_0277 : MapDataElement
{
    public E_0277()
    {
        DataType = DataType.AN;
        MinLength = 6;
        MaxLength = 6;
    }
}
```
### Creating EDI 997 - Functional Acknowledgment
```cs
string edi =
@"ISA*01*0000000000*01*0000000000*ZZ*ABCDEFGHIJKLMNO*ZZ*123456789012345*101127*1719*U*00400*000003438*0*P*>
GS*OW*7705551212*3111350000*20000128*0557*3317*T*004010
ST*940*0001
W05*N*538686**001001*538686
LX*1
W01*12*CA*000100000010*VN*000100*UC*DEC0199******19991205
G69*11.500 STRUD BLUBRY
W76*56*500*LB*24*CF
SE*7*0001
GE*1*3317
IEA*1*000003438";

EdiDataReader r = new EdiDataReader();
EdiBatch ediBatch = r.FromString(edi);
            
//control whether you need to accept all transaction or report error is such.
AckBuilderSettings ackSettings = new AckBuilderSettings(AckValidationErrorBehavour.AcceptAll, false, 100, 200);
var ack = new AckBuilder(ackSettings);

//create FA object structure
EdiBatch ackBatch = ack.GetnerateAcknowledgment(ediBatch);

//Or create ack string/stream 
string data = ack.WriteToString(ediBatch);
```
**data** variable will contain 
```
ISA*00*          *00*          *ZZ*123456789012345*ZZ*ABCDEFGHIJKLMNO*171120*0215*U*00400*000000100*0*P*>
GS*FA*3111350000*7705551212*20171120*0215*200*X*004010
ST*997*0001
AK1*OW*3317
AK9*A*1*1*1
SE*4*0001
GE*1*200
IEA*1*000000100
```
### Complete usage examples can be found in the test project
## Roadmap:
 - ~~Json Serialization and Deserialization~~
 - ~~Xml Serialization and Deserialization~~
 - ~~Craft more maps~~ (Added all 004010 maps)
 - ~~997 generation~~
 - ~~HL loop hierarchical parsing~~
 - Composite data elements
 - HIPAA support
  