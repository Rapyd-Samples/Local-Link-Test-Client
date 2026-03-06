# Local-Link-Test-Client-
A lightweight test client designed to validate and troubleshoot Local Link integrations. It allows developers to simulate requests, test connectivity, and verify communication with Local Link over local networks. 

Process:

The terminal listens on port 8080.

Launch the LocalLink application on the terminal.

In the "Local link - Test app.exe" test program, enter the IP address of the terminal, which is displayed at the bottom of the terminal screen.

Also enter the terminal serial number, which can be found on the barcode located a the back of the device.

In the LocalLink app, select “Pair.”

Enter the pairing code into the "Local link - Test app.exe" test program and trigger a GET – PairRequest to the terminal.

The pairing response will return an authToken. This value must be included in the header of all subsequent requests.

When you submit a sale request, the response will return a UTI. This UTI should then be used to check the status of the transaction by sending a GetRequest.