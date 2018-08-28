# EdiEngine
Simple .NET EDI Reader, Writer and Validator.
Read, Write and Validate X12 EDI files with simple EDI Parser written on C#.
Main Features:
* **EDI to JSON and JSON to EDI conversion**. 
EdiEngine uses Newtonsoft Json for serialization, and raw Newtonsoft Json reader for Deserialization. Json is a handy extension for the library. Imagine you can parse your EDI object directly in Angular or JQuery app.
* **EDI to XML and XML to EDI conversion**. EdiEngine does not use XML as intermediate format, as many other engines do. 
It uses POCO objects and XML is just an extension
* **Configurable EDI X12 997 - Functional Acknowledgment** generation. You can setup whether to accept all messages, accept but say errors were noted or reject depending on your needs.
* **HL Loop Hierarchical parsing** - Create real tree structure basing on HL segment hierarchy. No need to map every HL to map, this means one map can serve multiple needs. Say for ASN it can be S-O-P-I or S-O-I hierarchy in one map.
* **Syntax Notes**. All types of [EDI Syntax notes](https://github.com/olmelabs/EdiEngine/wiki/Syntax-Notes) are supported. P Paired, R Required, E Exclusion, C Conditional, L List Conditional
* **Composite Data Elements** are supported, which is really important for HIPAA and sometimes for other transactions even in retail.
* **X12 Maps** Current repository contains all 004010 maps, including Purchase Order, Invoice, Shipment and many others.
You can easily craft yours on their basis.
* **VS2017 and .NET Core 2.0 support**. Repository contains projects both for VS2015 and VS2017. .NET core projects are targeted to .NET Standard 2.0, so EdiEngine may be used in your latest .NET core applications. Nuget contains .Net Standard 2.0 libraries as well.

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
 - ~~Syntax Notes~~
 - ~~Composite data elements~~
 - ~~.NET Core support~~
 - HIPAA support
  