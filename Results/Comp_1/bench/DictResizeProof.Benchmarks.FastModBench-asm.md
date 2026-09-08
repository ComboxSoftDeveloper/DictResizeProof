## .NET 10.0.11 (10.0.11, 10.0.1126.37416), X64 RyuJIT x86-64-v3 (Job: net10(Toolchain=net10))

```assembly
; DictResizeProof.Benchmarks.FastModBench.Remainder()
       mov       rdx,rcx
       mov       rcx,[rdx+8]
       mov       edx,[rdx+18]
       jmp       qword ptr [7FFE10DEFB70]; DictResizeProof.Subjects.SumRemainder(UInt32[], UInt32)
; Total bytes of code 16
```
```assembly
; DictResizeProof.Subjects.SumRemainder(UInt32[], UInt32)
       mov       r8d,edx
       xor       r10d,r10d
       mov       r9d,[rcx+8]
       test      r9d,r9d
       jle       short M01_L01
       add       rcx,10
       nop       dword ptr [rax+rax]
       nop       dword ptr [rax+rax]
M01_L00:
       mov       eax,[rcx]
       xor       edx,edx
       div       r8d
       add       r10d,edx
       add       rcx,4
       dec       r9d
       jne       short M01_L00
M01_L01:
       mov       eax,r10d
       ret
; Total bytes of code 55
```

## .NET 10.0.11 (10.0.11, 10.0.1126.37416), X64 RyuJIT x86-64-v3 (Job: net10(Toolchain=net10))

```assembly
; DictResizeProof.Benchmarks.FastModBench.FastMod()
       mov       r8,rcx
       mov       rcx,[r8+8]
       mov       edx,[r8+18]
       mov       r8,[r8+10]
       jmp       qword ptr [7FFE10DFFB70]; DictResizeProof.Subjects.SumFastMod(UInt32[], UInt32, UInt64)
; Total bytes of code 21
```
```assembly
; DictResizeProof.Subjects.SumFastMod(UInt32[], UInt32, UInt64)
       xor       eax,eax
       mov       r10d,[rcx+8]
       test      r10d,r10d
       jle       short M01_L01
       mov       edx,edx
       add       rcx,10
M01_L00:
       mov       r9d,[rcx]
       imul      r9,r8
       shr       r9,20
       inc       r9
       imul      r9,rdx
       shr       r9,20
       add       eax,r9d
       add       rcx,4
       dec       r10d
       jne       short M01_L00
M01_L01:
       ret
; Total bytes of code 52
```

## .NET 8.0.30 (8.0.30, 8.0.3026.36720), X64 RyuJIT x86-64-v3 (Job: net8(Toolchain=net8))

```assembly
; DictResizeProof.Benchmarks.FastModBench.Remainder()
       mov       rdx,rcx
       mov       rcx,[rdx+8]
       mov       edx,[rdx+18]
       jmp       qword ptr [7FFE1011DC08]; DictResizeProof.Subjects.SumRemainder(UInt32[], UInt32)
; Total bytes of code 16
```
```assembly
; DictResizeProof.Subjects.SumRemainder(UInt32[], UInt32)
       mov       r8d,edx
       xor       r10d,r10d
       xor       r9d,r9d
       mov       r11d,[rcx+8]
       test      r11d,r11d
       jle       short M01_L01
       nop       dword ptr [rax]
       nop       dword ptr [rax]
M01_L00:
       mov       eax,r9d
       mov       eax,[rcx+rax*4+10]
       xor       edx,edx
       div       r8d
       add       r10d,edx
       inc       r9d
       cmp       r11d,r9d
       jg        short M01_L00
M01_L01:
       mov       eax,r10d
       ret
; Total bytes of code 59
```

## .NET 8.0.30 (8.0.30, 8.0.3026.36720), X64 RyuJIT x86-64-v3 (Job: net8(Toolchain=net8))

```assembly
; DictResizeProof.Benchmarks.FastModBench.FastMod()
       mov       r8,rcx
       mov       rcx,[r8+8]
       mov       edx,[r8+18]
       mov       r8,[r8+10]
       jmp       qword ptr [7FFE1012DC20]; DictResizeProof.Subjects.SumFastMod(UInt32[], UInt32, UInt64)
; Total bytes of code 21
```
```assembly
; DictResizeProof.Subjects.SumFastMod(UInt32[], UInt32, UInt64)
       xor       eax,eax
       xor       r10d,r10d
       mov       r9d,[rcx+8]
       test      r9d,r9d
       jle       short M01_L01
       mov       edx,edx
M01_L00:
       mov       r11d,r10d
       mov       r11d,[rcx+r11*4+10]
       imul      r11,r8
       shr       r11,20
       inc       r11
       imul      r11,rdx
       shr       r11,20
       add       eax,r11d
       inc       r10d
       cmp       r9d,r10d
       jg        short M01_L00
M01_L01:
       ret
; Total bytes of code 55
```

## .NET 9.0.19 (9.0.19, 9.0.1926.36724), X64 RyuJIT x86-64-v3 (Job: net9(Toolchain=net9))

```assembly
; DictResizeProof.Benchmarks.FastModBench.Remainder()
       mov       rdx,rcx
       mov       rcx,[rdx+8]
       mov       edx,[rdx+18]
       jmp       qword ptr [7FFE1006ED60]; DictResizeProof.Subjects.SumRemainder(UInt32[], UInt32)
; Total bytes of code 16
```
```assembly
; DictResizeProof.Subjects.SumRemainder(UInt32[], UInt32)
       mov       r8d,edx
       xor       r10d,r10d
       mov       r9d,[rcx+8]
       test      r9d,r9d
       jle       short M01_L01
       add       rcx,10
       nop       dword ptr [rax+rax]
       nop       dword ptr [rax+rax]
M01_L00:
       mov       eax,[rcx]
       xor       edx,edx
       div       r8d
       add       r10d,edx
       add       rcx,4
       dec       r9d
       jne       short M01_L00
M01_L01:
       mov       eax,r10d
       ret
; Total bytes of code 55
```

## .NET 9.0.19 (9.0.19, 9.0.1926.36724), X64 RyuJIT x86-64-v3 (Job: net9(Toolchain=net9))

```assembly
; DictResizeProof.Benchmarks.FastModBench.FastMod()
       mov       r8,rcx
       mov       rcx,[r8+8]
       mov       edx,[r8+18]
       mov       r8,[r8+10]
       jmp       qword ptr [7FFE1006EC88]; DictResizeProof.Subjects.SumFastMod(UInt32[], UInt32, UInt64)
; Total bytes of code 21
```
```assembly
; DictResizeProof.Subjects.SumFastMod(UInt32[], UInt32, UInt64)
       xor       eax,eax
       mov       r10d,[rcx+8]
       test      r10d,r10d
       jle       short M01_L01
       mov       edx,edx
       add       rcx,10
M01_L00:
       mov       r9d,[rcx]
       imul      r9,r8
       shr       r9,20
       inc       r9
       imul      r9,rdx
       shr       r9,20
       add       eax,r9d
       add       rcx,4
       dec       r10d
       jne       short M01_L00
M01_L01:
       ret
; Total bytes of code 52
```

## .NET 10.0.11 (10.0.11, 10.0.1126.37416), X64 RyuJIT x86-64-v3 (Job: net10(Toolchain=net10))

```assembly
; DictResizeProof.Benchmarks.FastModBench.Remainder()
       mov       rdx,rcx
       mov       rcx,[rdx+8]
       mov       edx,[rdx+18]
       jmp       qword ptr [7FFE10E0FB70]; DictResizeProof.Subjects.SumRemainder(UInt32[], UInt32)
; Total bytes of code 16
```
```assembly
; DictResizeProof.Subjects.SumRemainder(UInt32[], UInt32)
       mov       r8d,edx
       xor       r10d,r10d
       mov       r9d,[rcx+8]
       test      r9d,r9d
       jle       short M01_L01
       add       rcx,10
       nop       dword ptr [rax+rax]
       nop       dword ptr [rax+rax]
M01_L00:
       mov       eax,[rcx]
       xor       edx,edx
       div       r8d
       add       r10d,edx
       add       rcx,4
       dec       r9d
       jne       short M01_L00
M01_L01:
       mov       eax,r10d
       ret
; Total bytes of code 55
```

## .NET 10.0.11 (10.0.11, 10.0.1126.37416), X64 RyuJIT x86-64-v3 (Job: net10(Toolchain=net10))

```assembly
; DictResizeProof.Benchmarks.FastModBench.FastMod()
       mov       r8,rcx
       mov       rcx,[r8+8]
       mov       edx,[r8+18]
       mov       r8,[r8+10]
       jmp       qword ptr [7FFE10DFFC60]; DictResizeProof.Subjects.SumFastMod(UInt32[], UInt32, UInt64)
; Total bytes of code 21
```
```assembly
; DictResizeProof.Subjects.SumFastMod(UInt32[], UInt32, UInt64)
       xor       eax,eax
       mov       r10d,[rcx+8]
       test      r10d,r10d
       jle       short M01_L01
       mov       edx,edx
       add       rcx,10
M01_L00:
       mov       r9d,[rcx]
       imul      r9,r8
       shr       r9,20
       inc       r9
       imul      r9,rdx
       shr       r9,20
       add       eax,r9d
       add       rcx,4
       dec       r10d
       jne       short M01_L00
M01_L01:
       ret
; Total bytes of code 52
```

## .NET 8.0.30 (8.0.30, 8.0.3026.36720), X64 RyuJIT x86-64-v3 (Job: net8(Toolchain=net8))

```assembly
; DictResizeProof.Benchmarks.FastModBench.Remainder()
       mov       rdx,rcx
       mov       rcx,[rdx+8]
       mov       edx,[rdx+18]
       jmp       qword ptr [7FFE1012D4B8]; DictResizeProof.Subjects.SumRemainder(UInt32[], UInt32)
; Total bytes of code 16
```
```assembly
; DictResizeProof.Subjects.SumRemainder(UInt32[], UInt32)
       mov       r8d,edx
       xor       r10d,r10d
       xor       r9d,r9d
       mov       r11d,[rcx+8]
       test      r11d,r11d
       jle       short M01_L01
       nop       dword ptr [rax]
       nop       dword ptr [rax]
M01_L00:
       mov       eax,r9d
       mov       eax,[rcx+rax*4+10]
       xor       edx,edx
       div       r8d
       add       r10d,edx
       inc       r9d
       cmp       r11d,r9d
       jg        short M01_L00
M01_L01:
       mov       eax,r10d
       ret
; Total bytes of code 59
```

## .NET 8.0.30 (8.0.30, 8.0.3026.36720), X64 RyuJIT x86-64-v3 (Job: net8(Toolchain=net8))

```assembly
; DictResizeProof.Benchmarks.FastModBench.FastMod()
       mov       r8,rcx
       mov       rcx,[r8+8]
       mov       edx,[r8+18]
       mov       r8,[r8+10]
       jmp       qword ptr [7FFE1013D4D0]; DictResizeProof.Subjects.SumFastMod(UInt32[], UInt32, UInt64)
; Total bytes of code 21
```
```assembly
; DictResizeProof.Subjects.SumFastMod(UInt32[], UInt32, UInt64)
       xor       eax,eax
       xor       r10d,r10d
       mov       r9d,[rcx+8]
       test      r9d,r9d
       jle       short M01_L01
       mov       edx,edx
M01_L00:
       mov       r11d,r10d
       mov       r11d,[rcx+r11*4+10]
       imul      r11,r8
       shr       r11,20
       inc       r11
       imul      r11,rdx
       shr       r11,20
       add       eax,r11d
       inc       r10d
       cmp       r9d,r10d
       jg        short M01_L00
M01_L01:
       ret
; Total bytes of code 55
```

## .NET 9.0.19 (9.0.19, 9.0.1926.36724), X64 RyuJIT x86-64-v3 (Job: net9(Toolchain=net9))

```assembly
; DictResizeProof.Benchmarks.FastModBench.Remainder()
       mov       rdx,rcx
       mov       rcx,[rdx+8]
       mov       edx,[rdx+18]
       jmp       qword ptr [7FFE1003EC88]; DictResizeProof.Subjects.SumRemainder(UInt32[], UInt32)
; Total bytes of code 16
```
```assembly
; DictResizeProof.Subjects.SumRemainder(UInt32[], UInt32)
       mov       r8d,edx
       xor       r10d,r10d
       mov       r9d,[rcx+8]
       test      r9d,r9d
       jle       short M01_L01
       add       rcx,10
       nop       dword ptr [rax+rax]
       nop       dword ptr [rax+rax]
M01_L00:
       mov       eax,[rcx]
       xor       edx,edx
       div       r8d
       add       r10d,edx
       add       rcx,4
       dec       r9d
       jne       short M01_L00
M01_L01:
       mov       eax,r10d
       ret
; Total bytes of code 55
```

## .NET 9.0.19 (9.0.19, 9.0.1926.36724), X64 RyuJIT x86-64-v3 (Job: net9(Toolchain=net9))

```assembly
; DictResizeProof.Benchmarks.FastModBench.FastMod()
       mov       r8,rcx
       mov       rcx,[r8+8]
       mov       edx,[r8+18]
       mov       r8,[r8+10]
       jmp       qword ptr [7FFE1003EC88]; DictResizeProof.Subjects.SumFastMod(UInt32[], UInt32, UInt64)
; Total bytes of code 21
```
```assembly
; DictResizeProof.Subjects.SumFastMod(UInt32[], UInt32, UInt64)
       xor       eax,eax
       mov       r10d,[rcx+8]
       test      r10d,r10d
       jle       short M01_L01
       mov       edx,edx
       add       rcx,10
M01_L00:
       mov       r9d,[rcx]
       imul      r9,r8
       shr       r9,20
       inc       r9
       imul      r9,rdx
       shr       r9,20
       add       eax,r9d
       add       rcx,4
       dec       r10d
       jne       short M01_L00
M01_L01:
       ret
; Total bytes of code 52
```

## .NET 10.0.11 (10.0.11, 10.0.1126.37416), X64 RyuJIT x86-64-v3 (Job: net10(Toolchain=net10))

```assembly
; DictResizeProof.Benchmarks.FastModBench.Remainder()
       mov       rdx,rcx
       mov       rcx,[rdx+8]
       mov       edx,[rdx+18]
       jmp       qword ptr [7FFE10DDFC60]; DictResizeProof.Subjects.SumRemainder(UInt32[], UInt32)
; Total bytes of code 16
```
```assembly
; DictResizeProof.Subjects.SumRemainder(UInt32[], UInt32)
       mov       r8d,edx
       xor       r10d,r10d
       mov       r9d,[rcx+8]
       test      r9d,r9d
       jle       short M01_L01
       add       rcx,10
       nop       dword ptr [rax+rax]
       nop       dword ptr [rax+rax]
M01_L00:
       mov       eax,[rcx]
       xor       edx,edx
       div       r8d
       add       r10d,edx
       add       rcx,4
       dec       r9d
       jne       short M01_L00
M01_L01:
       mov       eax,r10d
       ret
; Total bytes of code 55
```

## .NET 10.0.11 (10.0.11, 10.0.1126.37416), X64 RyuJIT x86-64-v3 (Job: net10(Toolchain=net10))

```assembly
; DictResizeProof.Benchmarks.FastModBench.FastMod()
       mov       r8,rcx
       mov       rcx,[r8+8]
       mov       edx,[r8+18]
       mov       r8,[r8+10]
       jmp       qword ptr [7FFE10DDFC60]; DictResizeProof.Subjects.SumFastMod(UInt32[], UInt32, UInt64)
; Total bytes of code 21
```
```assembly
; DictResizeProof.Subjects.SumFastMod(UInt32[], UInt32, UInt64)
       xor       eax,eax
       mov       r10d,[rcx+8]
       test      r10d,r10d
       jle       short M01_L01
       mov       edx,edx
       add       rcx,10
M01_L00:
       mov       r9d,[rcx]
       imul      r9,r8
       shr       r9,20
       inc       r9
       imul      r9,rdx
       shr       r9,20
       add       eax,r9d
       add       rcx,4
       dec       r10d
       jne       short M01_L00
M01_L01:
       ret
; Total bytes of code 52
```

## .NET 8.0.30 (8.0.30, 8.0.3026.36720), X64 RyuJIT x86-64-v3 (Job: net8(Toolchain=net8))

```assembly
; DictResizeProof.Benchmarks.FastModBench.Remainder()
       mov       rdx,rcx
       mov       rcx,[rdx+8]
       mov       edx,[rdx+18]
       jmp       qword ptr [7FFE1013D4B8]; DictResizeProof.Subjects.SumRemainder(UInt32[], UInt32)
; Total bytes of code 16
```
```assembly
; DictResizeProof.Subjects.SumRemainder(UInt32[], UInt32)
       mov       r8d,edx
       xor       r10d,r10d
       xor       r9d,r9d
       mov       r11d,[rcx+8]
       test      r11d,r11d
       jle       short M01_L01
       nop       dword ptr [rax]
       nop       dword ptr [rax]
M01_L00:
       mov       eax,r9d
       mov       eax,[rcx+rax*4+10]
       xor       edx,edx
       div       r8d
       add       r10d,edx
       inc       r9d
       cmp       r11d,r9d
       jg        short M01_L00
M01_L01:
       mov       eax,r10d
       ret
; Total bytes of code 59
```

## .NET 8.0.30 (8.0.30, 8.0.3026.36720), X64 RyuJIT x86-64-v3 (Job: net8(Toolchain=net8))

```assembly
; DictResizeProof.Benchmarks.FastModBench.FastMod()
       mov       r8,rcx
       mov       rcx,[r8+8]
       mov       edx,[r8+18]
       mov       r8,[r8+10]
       jmp       qword ptr [7FFE1015DC20]; DictResizeProof.Subjects.SumFastMod(UInt32[], UInt32, UInt64)
; Total bytes of code 21
```
```assembly
; DictResizeProof.Subjects.SumFastMod(UInt32[], UInt32, UInt64)
       xor       eax,eax
       xor       r10d,r10d
       mov       r9d,[rcx+8]
       test      r9d,r9d
       jle       short M01_L01
       mov       edx,edx
M01_L00:
       mov       r11d,r10d
       mov       r11d,[rcx+r11*4+10]
       imul      r11,r8
       shr       r11,20
       inc       r11
       imul      r11,rdx
       shr       r11,20
       add       eax,r11d
       inc       r10d
       cmp       r9d,r10d
       jg        short M01_L00
M01_L01:
       ret
; Total bytes of code 55
```

## .NET 9.0.19 (9.0.19, 9.0.1926.36724), X64 RyuJIT x86-64-v3 (Job: net9(Toolchain=net9))

```assembly
; DictResizeProof.Benchmarks.FastModBench.Remainder()
       mov       rdx,rcx
       mov       rcx,[rdx+8]
       mov       edx,[rdx+18]
       jmp       qword ptr [7FFE1006ED60]; DictResizeProof.Subjects.SumRemainder(UInt32[], UInt32)
; Total bytes of code 16
```
```assembly
; DictResizeProof.Subjects.SumRemainder(UInt32[], UInt32)
       mov       r8d,edx
       xor       r10d,r10d
       mov       r9d,[rcx+8]
       test      r9d,r9d
       jle       short M01_L01
       add       rcx,10
       nop       dword ptr [rax+rax]
       nop       dword ptr [rax+rax]
M01_L00:
       mov       eax,[rcx]
       xor       edx,edx
       div       r8d
       add       r10d,edx
       add       rcx,4
       dec       r9d
       jne       short M01_L00
M01_L01:
       mov       eax,r10d
       ret
; Total bytes of code 55
```

## .NET 9.0.19 (9.0.19, 9.0.1926.36724), X64 RyuJIT x86-64-v3 (Job: net9(Toolchain=net9))

```assembly
; DictResizeProof.Benchmarks.FastModBench.FastMod()
       mov       r8,rcx
       mov       rcx,[r8+8]
       mov       edx,[r8+18]
       mov       r8,[r8+10]
       jmp       qword ptr [7FFE1003EC88]; DictResizeProof.Subjects.SumFastMod(UInt32[], UInt32, UInt64)
; Total bytes of code 21
```
```assembly
; DictResizeProof.Subjects.SumFastMod(UInt32[], UInt32, UInt64)
       xor       eax,eax
       mov       r10d,[rcx+8]
       test      r10d,r10d
       jle       short M01_L01
       mov       edx,edx
       add       rcx,10
M01_L00:
       mov       r9d,[rcx]
       imul      r9,r8
       shr       r9,20
       inc       r9
       imul      r9,rdx
       shr       r9,20
       add       eax,r9d
       add       rcx,4
       dec       r10d
       jne       short M01_L00
M01_L01:
       ret
; Total bytes of code 52
```

