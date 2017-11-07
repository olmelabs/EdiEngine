# EdiEngine
Simple .NET EDI Reader, Writer and Validator.
Read, Write and Validate X12 EDI files with simple EDI Parser written on C#.

## Serialization \ Deserialization
Supports EDI to JSON and JSON to EDI conversion (uses Newtonsoft Json)

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

Complete usage examples can be found in the test project.

## Next steps:
 - Xml Serialization and Deserialization
 - HL loop hierarchical parsing
 - Craft more maps