using S3_Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace S3_EF
{
    public static partial class S3ContextData
    {
        public static List<USStateDocumentOutput> AddUSStateDocumentOutputData(this S3DbContext c)
        {
            List<USStateDocumentOutput> USStateDocumentOutputs = new List<USStateDocumentOutput> {
                new USStateDocumentOutput { 
                        USStateDocumentOutputId = new Guid("b5e1a2c9-7c4f-4d9f-8a3b-f1a2d3e9c8b7"), 
                        USStateDocumentTypeId = new Guid("f5a7e9b1-7c8d-4a0f-9d3a-b3c1d4f9e6b2"), 
                        DocumentOutputTypeId = new Guid("fa7c2b5e-6e3b-4a9f-b2d1-1d3f9e8b4c7f"), 
                        EffectiveStart = new DateTime(2024, 1, 1), 
                        DocumentContent = System.Text.Encoding.UTF8.GetBytes(@"CT~~CD,~CC^~CT~
^XA
~TA000
~JSN
^LT0
^MNW
^MTT
^PON
^PMN
^LH0,0
^JMA
^PR2,2
~SD15
^JUS
^LRN
^CI27
^PA0,1,1,0
^XZ
^XA
^MMT
^PW1800
^LL1200
^LS0
^FO115,98^GFA,1409,9160,40,:Z64:eJzFmrFu2zAURcUIgZxmcDtlKcC1SD9Cv9ClyNcEFJAlQIf8Qmd3yN6hdtGlYz8hQJcCHZrRaF2zImlLfDTf47VhNG9QYvng8upKfFKoVFXVdVVp85Q1mUxKm6ctLrXZevgolbYrZJQTa9dlSr29soleLrB762pdyk95rOyvDlzRX5PV241uvuGGfUwZzN/Gnl1i9gjn40k22m7HHfflauTk2mDF/EyG61w+dFOPeuMXmVIW89fsyxXy0yMn5qdzeplqQc7kuEx+duSk/Ib4CrkMp6Nwfpsst5vfdOBsJ+WnR04ct430QI5+kcxfS/XY+Ws4vaQsximOS1rf+YiJ/a8Bx73HOGVYjuRXR5h0/4jtSddfrPdb4GI9Oo9ofjbmhPxi7lEY17LjklKCXpxfTfSGL/bSO+g4DMOl87clx8vPX8rxhXIXDJf2v5uIk+4fcYDo9Sf1P83oSflJ919OT+JQf/H8TfO7A/OLurjob0r0+OL6QZpfrLcU7h+x3t8F5u/PA+bPUo70v2nKMf2PcMLEBDmlWY70PyLnJhLT/4icMK7FOHL3SLkovxuqt6yY/JQV9Pq6nM/8z1rmTvt939wvjcD1CfmdXTJ7d/MLKouKdtPdcYPKw8nla4qlDTCoPGqTyKX5hZ1ru1NJfqmM7C9TWX+ynouH5ZZ0/qL+eL39/bnmplk92v9Y7sD8ED0XzpTjkvwajkv81Ry3BLkkP16P5qc47kB/iJ4Lh9ej+R3bH3g+urmkd8D85bDDuMkZy9H+x8aXjMvGl9xXUe5O5Mb8NMstsFjouPzhUj129lr7Nc6Pt0f1Wp7rYs7wHHgY5O9fiQMPl/jTmF56y6VcNH8Fjjx3HpnjJ2/y/CzorY7sjzw/ixyWH+qPtr8XV6Yva2SuD6e7nc1meT1x/W+41Errk1uutD6pMnq59dOzQU9eP61Af9s1mKOtP2/Xs4d9TNWgP3R9PLvenlu/3+gV338YzF8F+svrZV59gPn9F3+5/AyYnwb9taC/BszvWeCGfWwZzF8wCLw/ukDm73YRuvT+o9ocMOCvBjn/h3DMZdbvh0X8VaH/udLYuP6AEU5h+flLutj/NgaB8xYMIlxjxfWrYXPj5q/7bSnm5y5Bf7xKWh111YbH2Pr7gyjXG1z4H5+/uB9sfpPz/nHIXYk/f93KAxu/1fZlyWAXbH4scNr7M8NTOff+t3UH+iF92s7rnQJnr33vT3LxamirN+6q3tpj35q379bznvtR0jOha5Wwau2bjPSSIdS1b1qL4TOXX2j6xffnCuzR4SZcege81RvtcfkFvdvi/x8osLX5F1PFk+FbPlVj8nNqHfD/B9dY36hWn15B3OPz+BM/f8Pbo6rU/9QCGrWqO4xLiu1/yeapis+Pbv4BEwi/bQ==:51A3
^FT423,185^A0N,82,81^FH\^CI28^FDNew York State Hunting License^FS^CI27
^FT433,377^A0N,167,167^FH\^CI28^FD2024^FS^CI27
^FT115,590^A0N,58,58^FH\^CI28^FD^VName$^FS^CI27
^FT115,704^A0N,58,58^FH\^CI28^FD^VAddress$^FS^CI27
^FT115,818^A0N,58,58^FH\^CI28^FD^VCSZ$^FS^CI27^PQ1,0,1,Y
^XZ
")
                },
                new USStateDocumentOutput { 
                    USStateDocumentOutputId = new Guid("e8d5b3c1-4f7a-4d2f-8b1e-c9a4e2f7b6d3"), 
                    USStateDocumentTypeId = new Guid("f5c1d8a7-8e4b-4a9e-9d3f-a7b4e2f9c6d3"), 
                    DocumentOutputTypeId = new Guid("fa7c2b5e-6e3b-4a9f-b2d1-1d3f9e8b4c7f"), 
                    EffectiveStart = new DateTime(2024, 1, 1),
                    DocumentContent = System.Text.Encoding.UTF8.GetBytes(@"CT~~CD,~CC^~CT~
^XA
~TA000
~JSN
^LT0
^MNW
^MTT
^PON
^PMN
^LH0,0
^JMA
^PR2,2
~SD15
^JUS
^LRN
^CI27
^PA0,1,1,0
^XZ
^XA
^MMT
^PW1800
^LL1200
^LS0
^FO115,98^GFA,1573,9884,28,:Z64:eJzNmT1u20AQhUkrhoy4UBWo5BFyBOoIuYFyBDeBGyNknSZXUGnkEBGr1L5AAMGV4QCKCgcWBIkKRZG7s/PzJNBR4DVc2A8fZ9/M7K60jKJqDLbzcj5/fPzmxm3Ujv7Wj83mZzXunNbb8rF0Wiy0J6edAS5KbK6aqM31MzauvCYmSjgx0YXXIqDF2+fwB3EPRMuYVgBuRjk2RkSbgng8oXSePKEkLyIxlOMVpBw3GGhpqK2oloT+bqjGJlrmwEQBNJrQPqvgsYnpM21NNN5p1GAvsw1ybgm0o+MB7pJpJeC2R2piBYJ80gLyfG4BR7UhX4FESzlH4o3tZ8odzXMxt0dWoJgmaTRhjzToq+I6+ktAvBRw6TOvn+cERrjMjse7mnKJsOf9Scxx8hzz8d4Dbmhyb6eK1HDvNKnhVGzPydb0/jQDjtO1Op5cCpQTtXP1w1y3eLI1vT/ZmoTrGE/pMcehOihrwXMp4mx/hsEZ0IrDnF0/yCF/2mo4xh/kusYDXHoCDvSntrk4TtdetP6UPdBxXdcD/+RC/Z0iHuK6rvcUcLq92t8XHau5saEVZmVrzqheXT8jmzVnuKvjGVnZc4a9nT+jCs087XiviTO6s/YH8wLiYc6uH+ISEC9FHPA3Bdy4Y7wMcJZ0iDO1mbn6an9d4yHuGtTvFPG6+ktAvLQj97/78xTz7Lr+zkE8uC8Bf133M3Q+mI32Ei4FnFXAkX3c1py1gRb28V5zsV0/5W7Qc5bBg+f70PYXfQWc0TEHP7/A7w+IGwMuBVy8Nf0ZGd1z+kT38fSADSfuXqqf9h5FbZl8r2kts2k4LaPtvZS2Btv7M82gu1/S5hLZmrsHy/4dtwaau+dT/F2BeA/gme4eM0XxZP0WIJ7LpxIP5cXdn2n9eRSnaIXtbztptARwg3IqtDahyULe3MxabiZbtNX6I7mNjhrtMpe7TMtFypoovCYCEk58jyAaegMhziXCwTclZoMeeDPDtXVHbtGRG3lN+JsQzurPSLkvz+149J5d3HtHlAvrh7hj3z8gjp+CpHxiKaEXSAXgSDrF0iUSb8/gfQ7j0KsJqvEz8DNISwk0mk5uj3IJW32U4yk7VuPxaPnY9nLzweaWNJ0sHn3LxbkZ1YaAYzmj3cLbM3hmD2hse6HdyftlRf2xflkHXGiwDLRw/T0FWmgweIXJPhXeBVr4WWQSaOEZGEqhwTzUEqoxbgC488zmLgAXZJRrwF987e19Ylj0m6STP5OcSAvOkYyuOBeNff24RO6HS8H5Ht0IjvTohGukR0cC9NxMaC6jG8CthORLL/JCSr+U2jngnEE5TW/wo9RcJR6kFoN4Z0Bzn2EQp/hz8dZSc/5KhXPbJ+JyO57sM1/A74rWFP7PG0WbNvYuFK0pfKFIzaa2mmhaomye4TOV6jlNDdfEm6na/nuEKjV5yXXOSqaru8rF6uZ5mGvi6Vrl75etPcfGPCutzK28jKvOzMx8LutfbSRV7WKjfumudha3i5UoqyjabRR5tR3qXH9Xu1iPN5hXXHSrav0f6r/r0bu3tXhka9F9Tv/6Cx2GC64=:CFB2
^FT423,185^A0N,82,81^FH\^CI28^FDIllinois Hunting License^FS^CI27
^FT433,377^A0N,167,167^FH\^CI28^FD2024^FS^CI27
^FT115,590^A0N,58,58^FH\^CI28^FD^VName$^FS^CI27
^FT115,704^A0N,58,58^FH\^CI28^FD^VAddress$^FS^CI27
^FT115,818^A0N,58,58^FH\^CI28^FD^VCSZ$^FS^CI27^PQ1,0,1,Y
^XZ
")
                },
                new USStateDocumentOutput { 
                    USStateDocumentOutputId = new Guid("c4f9b2a3-5e1d-4a0f-8d3e-f9a6d3e8c1b7"), 
                    USStateDocumentTypeId = new Guid("f5a7e9b1-7c8d-4a0f-9d3a-b3c1d4f9e6b2"), 
                    DocumentOutputTypeId = new Guid("fa7c2b5e-6e3b-4a9f-b2d1-1d3f9e8b4c7f"), 
                    EffectiveStart = new DateTime(2023, 1, 1), 
                    EffectiveEnd = new DateTime(2023, 12, 31),
                        DocumentContent = System.Text.Encoding.UTF8.GetBytes(@"CT~~CD,~CC^~CT~
^XA
~TA000
~JSN
^LT0
^MNW
^MTT
^PON
^PMN
^LH0,0
^JMA
^PR2,2
~SD15
^JUS
^LRN
^CI27
^PA0,1,1,0
^XZ
^XA
^MMT
^PW1800
^LL1200
^LS0
^FO115,98^GFA,1409,9160,40,:Z64:eJzFmrFu2zAURcUIgZxmcDtlKcC1SD9Cv9ClyNcEFJAlQIf8Qmd3yN6hdtGlYz8hQJcCHZrRaF2zImlLfDTf47VhNG9QYvng8upKfFKoVFXVdVVp85Q1mUxKm6ctLrXZevgolbYrZJQTa9dlSr29soleLrB762pdyk95rOyvDlzRX5PV241uvuGGfUwZzN/Gnl1i9gjn40k22m7HHfflauTk2mDF/EyG61w+dFOPeuMXmVIW89fsyxXy0yMn5qdzeplqQc7kuEx+duSk/Ib4CrkMp6Nwfpsst5vfdOBsJ+WnR04ct430QI5+kcxfS/XY+Ws4vaQsximOS1rf+YiJ/a8Bx73HOGVYjuRXR5h0/4jtSddfrPdb4GI9Oo9ofjbmhPxi7lEY17LjklKCXpxfTfSGL/bSO+g4DMOl87clx8vPX8rxhXIXDJf2v5uIk+4fcYDo9Sf1P83oSflJ919OT+JQf/H8TfO7A/OLurjob0r0+OL6QZpfrLcU7h+x3t8F5u/PA+bPUo70v2nKMf2PcMLEBDmlWY70PyLnJhLT/4icMK7FOHL3SLkovxuqt6yY/JQV9Pq6nM/8z1rmTvt939wvjcD1CfmdXTJ7d/MLKouKdtPdcYPKw8nla4qlDTCoPGqTyKX5hZ1ru1NJfqmM7C9TWX+ynouH5ZZ0/qL+eL39/bnmplk92v9Y7sD8ED0XzpTjkvwajkv81Ry3BLkkP16P5qc47kB/iJ4Lh9ej+R3bH3g+urmkd8D85bDDuMkZy9H+x8aXjMvGl9xXUe5O5Mb8NMstsFjouPzhUj129lr7Nc6Pt0f1Wp7rYs7wHHgY5O9fiQMPl/jTmF56y6VcNH8Fjjx3HpnjJ2/y/CzorY7sjzw/ixyWH+qPtr8XV6Yva2SuD6e7nc1meT1x/W+41Errk1uutD6pMnq59dOzQU9eP61Af9s1mKOtP2/Xs4d9TNWgP3R9PLvenlu/3+gV338YzF8F+svrZV59gPn9F3+5/AyYnwb9taC/BszvWeCGfWwZzF8wCLw/ukDm73YRuvT+o9ocMOCvBjn/h3DMZdbvh0X8VaH/udLYuP6AEU5h+flLutj/NgaB8xYMIlxjxfWrYXPj5q/7bSnm5y5Bf7xKWh111YbH2Pr7gyjXG1z4H5+/uB9sfpPz/nHIXYk/f93KAxu/1fZlyWAXbH4scNr7M8NTOff+t3UH+iF92s7rnQJnr33vT3LxamirN+6q3tpj35q379bznvtR0jOha5Wwau2bjPSSIdS1b1qL4TOXX2j6xffnCuzR4SZcege81RvtcfkFvdvi/x8osLX5F1PFk+FbPlVj8nNqHfD/B9dY36hWn15B3OPz+BM/f8Pbo6rU/9QCGrWqO4xLiu1/yeapis+Pbv4BEwi/bQ==:51A3
^FT423,185^A0N,82,81^FH\^CI28^FDNew York State Hunting License^FS^CI27
^FT433,377^A0N,167,167^FH\^CI28^FD2023^FS^CI27
^FT115,590^A0N,58,58^FH\^CI28^FD^VName$^FS^CI27
^FT115,704^A0N,58,58^FH\^CI28^FD^VAddress$^FS^CI27
^FT115,818^A0N,58,58^FH\^CI28^FD^VCSZ$^FS^CI27^PQ1,0,1,Y
^XZ
")
                },
                new USStateDocumentOutput { 
                    USStateDocumentOutputId = new Guid("a9f4c2e7-8d3b-4f5e-9a0c-b7d2f1e6c3f8"), 
                    USStateDocumentTypeId = new Guid("f5c1d8a7-8e4b-4a9e-9d3f-a7b4e2f9c6d3"), 
                    DocumentOutputTypeId = new Guid("fa7c2b5e-6e3b-4a9f-b2d1-1d3f9e8b4c7f"), 
                    EffectiveStart = new DateTime(2023, 1, 1), 
                    EffectiveEnd = new DateTime(2023, 12, 31),
                    DocumentContent = System.Text.Encoding.UTF8.GetBytes(@"CT~~CD,~CC^~CT~
^XA
~TA000
~JSN
^LT0
^MNW
^MTT
^PON
^PMN
^LH0,0
^JMA
^PR2,2
~SD15
^JUS
^LRN
^CI27
^PA0,1,1,0
^XZ
^XA
^MMT
^PW1800
^LL1200
^LS0
^FO115,98^GFA,1573,9884,28,:Z64:eJzNmT1u20AQhUkrhoy4UBWo5BFyBOoIuYFyBDeBGyNknSZXUGnkEBGr1L5AAMGV4QCKCgcWBIkKRZG7s/PzJNBR4DVc2A8fZ9/M7K60jKJqDLbzcj5/fPzmxm3Ujv7Wj83mZzXunNbb8rF0Wiy0J6edAS5KbK6aqM31MzauvCYmSjgx0YXXIqDF2+fwB3EPRMuYVgBuRjk2RkSbgng8oXSePKEkLyIxlOMVpBw3GGhpqK2oloT+bqjGJlrmwEQBNJrQPqvgsYnpM21NNN5p1GAvsw1ybgm0o+MB7pJpJeC2R2piBYJ80gLyfG4BR7UhX4FESzlH4o3tZ8odzXMxt0dWoJgmaTRhjzToq+I6+ktAvBRw6TOvn+cERrjMjse7mnKJsOf9Scxx8hzz8d4Dbmhyb6eK1HDvNKnhVGzPydb0/jQDjtO1Op5cCpQTtXP1w1y3eLI1vT/ZmoTrGE/pMcehOihrwXMp4mx/hsEZ0IrDnF0/yCF/2mo4xh/kusYDXHoCDvSntrk4TtdetP6UPdBxXdcD/+RC/Z0iHuK6rvcUcLq92t8XHau5saEVZmVrzqheXT8jmzVnuKvjGVnZc4a9nT+jCs087XiviTO6s/YH8wLiYc6uH+ISEC9FHPA3Bdy4Y7wMcJZ0iDO1mbn6an9d4yHuGtTvFPG6+ktAvLQj97/78xTz7Lr+zkE8uC8Bf133M3Q+mI32Ei4FnFXAkX3c1py1gRb28V5zsV0/5W7Qc5bBg+f70PYXfQWc0TEHP7/A7w+IGwMuBVy8Nf0ZGd1z+kT38fSADSfuXqqf9h5FbZl8r2kts2k4LaPtvZS2Btv7M82gu1/S5hLZmrsHy/4dtwaau+dT/F2BeA/gme4eM0XxZP0WIJ7LpxIP5cXdn2n9eRSnaIXtbztptARwg3IqtDahyULe3MxabiZbtNX6I7mNjhrtMpe7TMtFypoovCYCEk58jyAaegMhziXCwTclZoMeeDPDtXVHbtGRG3lN+JsQzurPSLkvz+149J5d3HtHlAvrh7hj3z8gjp+CpHxiKaEXSAXgSDrF0iUSb8/gfQ7j0KsJqvEz8DNISwk0mk5uj3IJW32U4yk7VuPxaPnY9nLzweaWNJ0sHn3LxbkZ1YaAYzmj3cLbM3hmD2hse6HdyftlRf2xflkHXGiwDLRw/T0FWmgweIXJPhXeBVr4WWQSaOEZGEqhwTzUEqoxbgC488zmLgAXZJRrwF987e19Ylj0m6STP5OcSAvOkYyuOBeNff24RO6HS8H5Ht0IjvTohGukR0cC9NxMaC6jG8CthORLL/JCSr+U2jngnEE5TW/wo9RcJR6kFoN4Z0Bzn2EQp/hz8dZSc/5KhXPbJ+JyO57sM1/A74rWFP7PG0WbNvYuFK0pfKFIzaa2mmhaomye4TOV6jlNDdfEm6na/nuEKjV5yXXOSqaru8rF6uZ5mGvi6Vrl75etPcfGPCutzK28jKvOzMx8LutfbSRV7WKjfumudha3i5UoqyjabRR5tR3qXH9Xu1iPN5hXXHSrav0f6r/r0bu3tXhka9F9Tv/6Cx2GC64=:CFB2
^FT423,185^A0N,82,81^FH\^CI28^FDIllinois Hunting License^FS^CI27
^FT433,377^A0N,167,167^FH\^CI28^FD2023^FS^CI27
^FT115,590^A0N,58,58^FH\^CI28^FD^VName$^FS^CI27
^FT115,704^A0N,58,58^FH\^CI28^FD^VAddress$^FS^CI27
^FT115,818^A0N,58,58^FH\^CI28^FD^VCSZ$^FS^CI27^PQ1,0,1,Y
^XZ
")
                }
            };

            return USStateDocumentOutputs;
        }
    }
}
