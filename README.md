# EdiEngine
Simple .NET EDI Reader, Writer and Validator.
Read, Write and Validate X12 EDI files with simple EDI Parser written on C#.
Main Features:
* **EDI to JSON and JSON to EDI conversion**. EdiEngine uses Newtonsoft Json for serialization, and raw Newtonsoft Json reader for Deserialization. Json is a handy extension for the library. Imagine you can parse your EDI object directly in Angular or JQuery app.
* **EDI to XML and XML to EDI conversion**. Edi Engine does not use XML as intermediate format, as many other engines do. 
It uses POCO objects and XML is just an extension
* **Configurable EDI X12 997 - Functional Acknowledgment** generation. You can setup whether to accept all messages, accept but say errors were noted or reject depending on your needs.
* **HL Loop Hierarchical parsing** - Create real tree structure basing on HL segment hierarchy. No need to map every HL to map, this means one map can serve multiple need. Say for ASN it can be S-O-P-I or S-O-I hierarchy in one map.
* **X12 Maps**. Current repository contains all 004010 maps, including Purchase Order, Invoice, Shipment and many others.
You can easily craft yours on their basis.

## Installation
Clone repository or Install Nuget Package
```
Install-Package xEdi.EdiEngine
```
## How To's
Please use [Wiki](https://github.com/olmelabs/EdiEngine/wiki) for documentation and usage examples.

#### Complete usage examples can be found in the test project ####
Note - test project is not a part of nuget package. You have to clone repository.

## Roadmap:
 - ~~Json Serialization and Deserialization~~
 - ~~Xml Serialization and Deserialization~~
 - ~~Craft more maps~~ (Added all 004010 maps)
 - ~~997 generation~~
 - ~~HL loop hierarchical parsing~~
 - Composite data elements
 - HIPAA support
  