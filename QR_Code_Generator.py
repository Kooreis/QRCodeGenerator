Sure, here is a simple Python script for a console application that generates QR codes:

```python
import qrcode

def generate_qr(data, file_name):
    qr = qrcode.QRCode(
        version=1,
        error_correction=qrcode.constants.ERROR_CORRECT_H,
        box_size=10,
        border=4,
    )
    qr.add_data(data)
    qr.make(fit=True)

    img = qr.make_image(fill_color="black", back_color="white")
    img.save(file_name)

if __name__ == "__main__":
    data = input("Enter the data for the QR code: ")
    file_name = input("Enter the filename (with .png extension): ")
    generate_qr(data, file_name)
    print("QR Code generated successfully!")
```

Please note that you need to have the `qrcode` library installed. You can install it using pip:

```bash
pip install qrcode[pil]
```