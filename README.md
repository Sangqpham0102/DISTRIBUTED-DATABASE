# BAI1 Image Processing Application

This application is designed to demonstrate basic image processing techniques using C# and Windows Forms. The main functionalities include converting a color image to grayscale, histogram equalization, brightness adjustment, contrast stretching, thresholding, bitwise operations, and image inversion.

## Features

1. **Open Image**: Load an image from your local file system.
2. **Save Image**: Save the processed image to your local file system.
3. **Convert to Grayscale**: Convert a color image to grayscale using pixel manipulation.
4. **Histogram Equalization**: Enhance the contrast of the image by distributing the light intensity values.
5. **Brightness Adjustment**: Increase the brightness of the image.
6. **Contrast Stretching**: Stretch the contrast of the image to improve its appearance.
7. **Thresholding**: Convert the image to a binary image based on a threshold value.
8. **Bitwise Operations**: Perform AND, OR, XOR, and NOT operations between two images.
9. **Image Inversion**: Invert the colors of the image.

## Getting Started

### Prerequisites

- .NET Framework
- Visual Studio

### Installation

1. Clone the repository:
   ```sh
   git clone https://github.com/Sangqpham0102/WdForm.git
   ```

2. Open the project in Visual Studio.

3. Build and run the project.

## Usage

### Opening an Image

1. Click on `File > Open` to select an image file from your computer.
2. The selected image will be displayed in the first picture box.

### Saving an Image

1. After processing the image, click on `File > Save`.
2. Choose the location and format to save the processed image.

### Image Processing Operations

1. **Convert to Grayscale**:
   - Click on `Image > Set Pixel`.
   - The grayscale image will be displayed in the second picture box.

2. **Histogram Equalization**:
   - Click on `Image > Equalization`.
   - The equalized image will be displayed in the second picture box.

3. **Brightness Adjustment**:
   - Click on `Image > Brightness`.
   - The brightened image will be displayed in the second picture box.

4. **Contrast Stretching**:
   - Click on `Image > Stretch`.
   - The contrast-stretched image will be displayed in the second picture box.

5. **Thresholding**:
   - Click on `Image > Threshold`.
   - The thresholded image will be displayed in the second picture box.

6. **Bitwise Operations**:
   - Load two images using `File > Open`.
   - Perform AND, OR, XOR operations by clicking on the corresponding menu items under `Image`.

7. **Image Inversion**:
   - Click on `Image > Not`.
   - The inverted image will be displayed in the second picture box.

## Code Overview

The main form (`FrmBai1`) contains the following key methods:

- `openToolStripMenuItem_Click`: Handles opening an image.
- `saveToolStripMenuItem_Click`: Handles saving the processed image.
- `setPixelToolStripMenuItem_Click`: Converts the image to grayscale using the set/get pixel method.
- `lockbitToolStripMenuItem_Click`: Converts the image to grayscale using the `LockBits` method for faster processing.
- `equaToolStripMenuItem_Click`: Performs histogram equalization.
- `slideToolStripMenuItem_Click`: Adjusts the brightness of the image.
- `strToolStripMenuItem_Click`: Stretches the contrast of the image.
- `thrToolStripMenuItem_Click`: Applies thresholding to the image.
- `notToolStripMenuItem_Click`: Inverts the colors of the image.
- `andToolStripMenuItem_Click`: Performs a bitwise AND operation between two images.
- `orToolStripMenuItem_Click`: Performs a bitwise OR operation between two images.
- `xORToolStripMenuItem_Click`: Performs a bitwise XOR operation between two images.


## License

This project is licensed under the MIT License.

---

This README.md provides a comprehensive overview of the project's functionalities, installation steps, usage instructions, and code details. Feel free to customize it further based on your specific needs.
