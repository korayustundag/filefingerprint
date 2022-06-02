# File Fingerprint
Shows the fingerprints of the selected files.
## Description
It provides you with detailed fingerprint reports of the file or files you want.
## Built With
File Fingerprint works without any requirements.
* [.NET 6](https://dotnet.microsoft.com)
## Getting Started
### Supported OS
* Windows (x86, x64, arm, arm64)
* MacOS (x64)
* Linux (x64, arm, arm64)
### Installation
* [Click here](https://github.com/korayustundag/filefingerprint/releases/) to go to the download page and download the version that suits you.
#### For Windows
* Extract the archive to any folder.
#### For MacOS
* Extract the archive to any folder.
#### For Linux
* If you downloaded the **Archive version**, extract the archive to any folder.
* If you have downloaded the Deb package follow the instructions in Deb package installation instructions.
## Usage
### For Windows

Console:

    ff anyfile.ext anyfile2.ext "any file3.ext"
PowerShell:

    .\ff.exe anyfile.ext anyfile2.ext "any file3.ext"
### For MacOS
Console:

    ./ff anyfile.ext anyfile2.ext "any file3.ext"
### For Linux
#### Portable Version
Console:

    ./ff anyfile.ext anyfile2.ext "any file3.ext"
#### Deb Package
* Go to the folder where the deb package is located.

Install Commands:

AMD64: `sudo dpkg -i filefingerprint_1.0_amd64.deb`

ARM: `sudo dpkg -i filefingerprint_1.0_arm.deb`

ARM64: `sudo dpkg -i filefingerprint_1.0_arm64.deb`

Console:

    ff anyfile.ext anyfile2.ext "any file3.ext"
#### A note for Linux and MacOS users:
* If File Fingerprint doesn't work, don't forget to grant run permissions.
* Command: `chmod +x ff`

#### Example HTML Output
| File Name | File Size| Creation Date | Fingerprint |
|--|--|--|--|
| filefingerprint_1.0_amd64.deb | 3 MB | 05.26.2022 9:48:15 pm | 0245bb3f5b1c062da928308fb51c97aa4225c2911526f5abff07dbecb6d29467 |
| filefingerprint_linux-x64.tar.gz | 5 MB | 05.26.2022 9:48:15 pm | 5d235519a85b36a517bbdfc653383ae782a8695a1935206cfbde639561c6c589 |
| filefingerprint_win-x64.zip | 6 MB | 05.26.2022 9:48:15 pm | 7f3ce8f59f17aa1e0153ecd5104e905c6da8ef8923c814f967e51de4e93d61f2 |
| filefingerprint_macOS.zip | 5 MB | 05.26.2022 9:48:15 pm | 29c1be7e10286b04e7a89f66be0aaadbc92e494e9c4a8201ce7e4c352ba6f117 |

## Roadmap
- [x] Exporting html report file
- [x] Platform-based exit codes
- [ ] Fingerprint verification
- [ ] Publisher-assisted fingerprint verification
- [ ] Multi-language Support
	- [x] English
	- [ ] German
	- [ ] French
	- [ ] Spanish
	- [ ] Turkish
	- [ ] Polish
	- [ ] Japanese
	- [ ] Chinese
## License
Distributed under the MIT License. See `LICENSE` file for more information.
## Authors
Koray ÜSTÜNDAĞ -- [GitHub](https://github.com/korayustundag)
## Contact
Koray ÜSTÜNDAĞ -- mskorayustundag@gmail.com
