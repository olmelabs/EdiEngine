# EdiEngine
Simple .NET EDI Reader, Writer and Validator.
Read, Write and Validate X12 EDI files with simple EDI Parser written on C#.
## Serialization \ Deserialization
Supports EDI to JSON and JSON to EDI conversion (uses Newtonsoft Json)
### Reading EDI and Writing JSON example
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
```
### Reading JSON example
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
### Writing complete EDI Envelope with one message
```cs
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
    "00401", "004010", "T", 100, 200);

EdiDataWriter w = new EdiDataWriter(settings);
string data = w.WriteToString(b);
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
Complete usage examples can be found in the test project.

## Next steps:
 - Xml Serialization and Deserialization
 - HL loop hierarchical parsing
 - Craft more maps