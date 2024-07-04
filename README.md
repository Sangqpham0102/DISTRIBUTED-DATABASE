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


# BAI2 Image Histogram and Point Processing Application

This application demonstrates basic image processing techniques using C# and Windows Forms, focusing on histogram calculation and simple point processing operations.

## Features

1. **Open Image**: Load an image from your local file system.
2. **Save Image**: Save the processed image to your local file system.
3. **Calculate Histogram**: Generate and display the histogram of the loaded image.
4. **Point Processing**: Apply simple point processing operations, such as brightness adjustment, to the image.
5. **Clear Images**: Clear the loaded and processed images.

## Usage

1. **Open Image**: Click on `File > Open` to load an image.
2. **Save Image**: Click on `File > Save` to save the processed image.
3. **Calculate Histogram**: Click on `Image > Histogram` to generate and display the histogram.
4. **Point Processing**: Click on `Image > Point Processing` to apply brightness adjustment.
5. **Clear Images**: Click on `Edit > Clear` to clear the images.

## Code Overview

The main form (`Histogram`) contains the following key methods:

- `openToolStripMenuItem_Click`: Handles opening an image.
- `saveToolStripMenuItem_Click`: Handles saving the processed image.
- `exitToolStripMenuItem_Click`: Handles exiting the application.
- `hisogramToolStripMenuItem_Click`: Calculates and displays the histogram of the image.
- `clearToolStripMenuItem_Click`: Clears the loaded and processed images.
- `pointProcessingToolStripMenuItem_Click`: Applies a brightness adjustment to the image.


Dưới đây là mô tả ngắn gọn cho bài tập này để hiển thị trên README của GitHub:

# BAI 3 Image Brightness Adjustment Application

This application demonstrates the adjustment of image brightness using C# and Windows Forms.

## Features

1. **Open Image**: Load an image from your local file system.
2. **Save Image**: Save the adjusted image to your local file system.
3. **Adjust Brightness**: Use a trackbar to adjust the brightness of the loaded image in real-time.
4. **Close Application**: Close the application.

## Usage

1. **Open Image**: Click on `Open` to load an image.
2. **Save Image**: Click on `Save` to save the adjusted image.
3. **Adjust Brightness**: Use the trackbar to change the brightness level. The brightness value is displayed in real-time.
4. **Close Application**: Click on `Close` to exit the application.

## Code Overview

The main form (`Brightness`) contains the following key methods:

- `btnOpen_Click`: Handles opening an image.
- `btnSave_Click`: Handles saving the adjusted image.
- `btnClose_Click`: Handles closing the application.
- `traBrightness_Scroll_1`: Adjusts the image brightness based on the trackbar value.
- `AdjustBrightness`: Applies a color matrix to adjust the image brightness.



# BAI 4 Image Contrast Adjustment Application

This application enables users to adjust the contrast of images in various formats (PNG, JPEG, BMP) using C# and Windows Forms.

## Features

1. **Load Image**: Open images in PNG, JPEG, or BMP format.
2. **Adjust Contrast**: Use a slider to modify the image contrast in real-time.
3. **Save Image**: Save the adjusted image with the specified file format.
4. **Exit**: Close the application.

## Usage

1. **Load Image**: Click `Load` to select an image file from your computer.
2. **Adjust Contrast**: Move the slider (`Threshold`) to change the contrast level. The current threshold value is displayed.
3. **Save Image**: Click `Save` to save the modified image with the chosen file format.
4. **Exit**: Click `Exit` to close the application.

## Code Overview

The main form (`ImgContrast`) includes methods for:

- `btnLoad_Click`: Loads an image and displays it in a PictureBox.
- `ThresholdValueChangEvH`: Handles contrast adjustment using a slider (`trcThr`).
- `btnSave_Click`: Saves the adjusted image with the selected file format.
- `ApplyFilter`: Applies contrast adjustment either as a preview (`preview = true`) or directly to the original image (`preview = false`).


This C# application allows users to apply a color averaging filter to images with options for edge detection and color shifting. Here's a concise description for your GitHub README:

---

# BAI 5 Color Averaging Application

This application applies a color averaging filter to images, with additional options for edge detection and color shifting. Developed using C# and Windows Forms.

## Features

1. **Load Image**: Open images in PNG, JPEG, or BMP format.
2. **Adjust Filter Parameters**:
   - **Edge Detection**: Choose from different edge detection options or select "None".
   - **Color Shifting**: Shift colors left, right, or apply no shift.
   - **RGB Channels**: Select which color channels (Red, Green, Blue) to include in the averaging.
3. **Apply Filter**: Apply the color averaging filter to preview changes in real-time.
4. **Save Image**: Save the modified image with the chosen file format.
5. **Exit**: Close the application.

## Usage

1. **Load Image**: Click `Open` to select an image file from your computer.
2. **Adjust Filter Settings**: Use the dropdowns and checkboxes to configure edge detection, color shifting, and RGB channel options.
3. **Apply Filter**: Changes are previewed in real-time on the image.
4. **Save Image**: Click `Save` to save the modified image with the selected file format.
5. **Exit**: Click `Exit` to close the application.

## Code Overview

The main form (`ColorAverage`) includes methods for:

- `btnOpen_Click`: Loads an image and displays it in a PictureBox for preview.
- `NeighbourCountValueChangedEvH`: Handles changes in filter parameters (edge detection and color shifting).
- `btnSave_Click`: Saves the modified image with the selected file format.
- `ApplyFilter`: Applies the color averaging filter based on selected options (preview or directly to the original image).

Here's a concise description of the DoG (Difference of Gaussians) image processing application for your GitHub README:

---

# BAI 6 Difference of Gaussians (DoG) Image Processing

This application applies the Difference of Gaussians (DoG) filter to images, offering various types and options for edge detection. Developed using C# and Windows Forms.

## Features

1. **Load Image**: Open images in PNG, JPEG, or BMP format.
2. **Adjust Filter Parameters**:
   - **Edge Detection**: Choose from different DoG types:
     - DoG Type 1
     - DoG Type 2
     - DoG Type 1 - Invert
     - DoG Type 2 - Invert
     - DoG Type 1 - 128 Bias
     - DoG Type 2 - 96 Bias
   - **Preview**: See real-time previews of the filter effects.
3. **Apply Filter**: Apply the selected DoG filter to the loaded image.
4. **Save Image**: Save the modified image with the chosen file format.
5. **Exit**: Close the application.

## Usage

1. **Load Image**: Click `Open` to select an image file from your computer.
2. **Adjust Filter Settings**: Use the dropdown menu to choose the desired DoG type.
3. **Apply Filter**: Changes are previewed in real-time on the image.
4. **Save Image**: Click `Save` to save the modified image with the selected file format.
5. **Exit**: Click `Exit` to close the application.

## Code Overview

The main form (`DoG`) includes methods for:

- `btnOpen_Click`: Loads an image and displays it in a PictureBox for preview.
- `NeighbourCountValueChangedEvH`: Handles changes in filter parameters (DoG type selection).
- `btnSave_Click`: Saves the modified image with the selected file format.
- `ApplyFilter`: Applies the selected DoG filter based on user options (preview or directly to the original image).



# BAI 7 Boundary Extraction Image Processing

This application performs boundary extraction operations on images using various filters and structuring elements. Developed using C# and Windows Forms.

## Features

1. **Load Image**: Open images in PNG, JPEG, or BMP formats.
2. **Adjust Filter Parameters**:
   - **Filter Type**: Choose from Boundary Extraction, Boundary Sharpen, and Boundary Trace.
   - **Filter Size**: Select the size of the structuring element (SE) for the filter.
   - **Color Channels**: Optionally apply filters to specific color channels (R, G, B).
   - **Structuring Element**: Customize the structuring element shape and size interactively.
3. **Live Preview**: See real-time previews of the filter effects with live preview enabled.
4. **Apply Filter**: Apply the selected filter to the loaded image.
5. **Save Image**: Save the modified image with the chosen file format.
6. **Exit**: Close the application.

## Usage

1. **Load Image**: Click `Open` to select an image file from your computer.
2. **Adjust Filter Settings**: Use dropdown menus and checkboxes to customize the filter parameters.
3. **Live Preview**: Enable `Live Preview` to see immediate updates as you adjust settings.
4. **Apply Filter**: Click `Apply` to apply the selected filter to the loaded image.
5. **Save Image**: Click `Save` to save the modified image with the selected file format.
6. **Exit**: Click `Exit` to close the application.

## Code Overview

The main form (`BoundaryEx`) includes methods for:

- `btnOpen_Click`: Loads an image and displays it in a PictureBox for preview.
- `FilterValueChangedEvH`, `FilterSizeValueChangedEventH`, `SCCheckedChanged`: Handles changes in filter parameters and structuring element customization.
- `btnSave_Click`: Saves the modified image with the selected file format.
- `ApplyFilter`: Applies the selected boundary extraction filter based on user options (preview or directly to the original image).
- `GetSE`: Retrieves the structuring element configuration based on user-defined settings.


Your `ImgCartoonEe` application appears to be a Windows Forms application that applies a cartoon effect filter to images. Here’s a concise description for your GitHub README:

---

# BAI 8 Cartoon Effect Image Processing

This application applies a cartoon effect filter to images using various smoothing filters and threshold adjustments. Developed using C# and Windows Forms.

## Features

1. **Load Image**: Open images in PNG, JPEG, or BMP formats.
2. **Adjust Threshold**: Use a slider to control the threshold for the cartoon effect.
3. **Select Smoothing Filter**: Choose from a variety of smoothing filters to preprocess the image before applying the cartoon effect.
4. **Live Preview**: See real-time previews of the cartoon effect with live preview enabled.
5. **Apply Filter**: Apply the selected cartoon effect to the loaded image.
6. **Save Image**: Save the modified image with the chosen file format.
7. **Exit**: Close the application.

## Usage

1. **Load Image**: Click `Open` to select an image file from your computer.
2. **Adjust Threshold**: Move the slider to set the threshold for the cartoon effect.
3. **Select Smoothing Filter**: Choose a smoothing filter type from the dropdown menu.
4. **Live Preview**: Enable `Live Preview` to see immediate updates as you adjust settings.
5. **Apply Filter**: Click `Apply` to apply the cartoon effect with the selected settings to the loaded image.
6. **Save Image**: Click `Save` to save the modified image with the selected file format.
7. **Exit**: Click `Exit` to close the application.

## Code Overview

The main form (`ImgCartoonEe`) includes methods for:

- `btnOpen_Click`: Loads an image and displays it in a PictureBox for preview.
- `FilterValueChangedEvH`: Handles changes in the threshold slider value and updates the UI accordingly.
- `ApplyFilter`: Applies the cartoon effect filter based on user-selected options (preview or directly to the original image).
- `btnSave_Click`: Saves the modified image with the selected file format.
- Integration with `ExtBitmap` namespace for various smoothing filter types and the `CartoonEffectFilter` method.



## License

This project is licensed under the MIT License.

---

This README.md provides a comprehensive overview of the project's functionalities, installation steps, usage instructions, and code details. Feel free to customize it further based on your specific needs.
