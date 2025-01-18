// Please see documentation at https://learn.microsoft.com/aspnet/core/client-side/bundling-and-minification
// for details on configuring this project to bundle and minify static web assets.

// Write your JavaScript code.
window.addEventListener("DOMContentLoaded", function () {
    $(".table").dataTable();
})

document.getElementById('categoryFilter').addEventListener('click', function () {
    var selectedCategory = document.getElementById('categoryChosen').value;

    fetch('/FilterDevicesByCategory', {
        method: 'POST',
        headers: {
            'Content-Type': 'application/json'
        },
        body: JSON.stringify(selectedCategory)
    })
        .then(response => response.json())
        .then(devices => {
            
            // Clear current device listings
            var deviceContainer = document.getElementById('deviceContainer');
            deviceContainer.innerHTML = '';
            // Populate with new devices
            for (const device of devices) {
                console.log(device);
                console.log(device.Name);
                var deviceElement = document.createElement('tr');
                deviceElement.innerHTML =
                    `
                        <td>
                            ${device.id}
                        </td>
                        <td>
                            ${device.name}
                        </td>
                        <td>
                            ${device.categoryId}
                        </td>
                        <td>
                            ${device.status}
                        </td>
                        <td>
                            ${device.entryDate}
                        </td>
                        <td>
                            <a href="Device/Edit/${device.id}" class="btn btn-outline-primary" asp-route-id="@item.Id">Edit</a> |
                            <a href="Device/Details/${device.id}" class="btn btn-outline-dark" asp-route-id="@item.Id">Details</a> |
                            <a href="Device/Delete/${device.id}" class="btn btn-outline-danger" asp-route-id="@item.Id">Delete</a>
                        </td>
                `;

                deviceContainer.appendChild(deviceElement);
            }
        })
        .catch(error => console.error('Error:', error));
});
document.getElementById('statusFilter').addEventListener('click', function () {
    var selectedStatus = document.getElementById('statusChosen').value;

    fetch('/FilterDevicesByStatus', {
        method: 'POST',
        headers: {
            'Content-Type': 'application/json'
        },
        body: JSON.stringify(selectedStatus)
    })
        .then(response => response.json())
        .then(devices => {

            // Clear current device listings
            var deviceContainer = document.getElementById('deviceContainer');
            deviceContainer.innerHTML = '';
            // Populate with new devices
            for (const device of devices) {
                console.log(device);
                console.log(device.Name);
                var deviceElement = document.createElement('tr');
                deviceElement.innerHTML =
                    `
                        <td>
                            ${device.id}
                        </td>
                        <td>
                            ${device.name}
                        </td>
                        <td>
                            ${device.categoryId}
                        </td>
                        <td>
                            ${device.status}
                        </td>
                        <td>
                            ${device.entryDate}
                        </td>
                        <td>
                            <a href="Device/Edit/${device.id}" class="btn btn-outline-primary" asp-route-id="@item.Id">Edit</a> |
                            <a href="Device/Details/${device.id}" class="btn btn-outline-dark" asp-route-id="@item.Id">Details</a> |
                            <a href="Device/Delete/${device.id}" class="btn btn-outline-danger" asp-route-id="@item.Id">Delete</a>
                        </td>
                `;

                deviceContainer.appendChild(deviceElement);
            }
        })
        .catch(error => console.error('Error:', error));
});
document.getElementById('nameFilter').addEventListener('click', function () {
    var selectedName = document.getElementById('nameChosen').value;

    fetch('/FilterDevicesByName', {
        method: 'POST',
        headers: {
            'Content-Type': 'application/json'
        },
        body: JSON.stringify(selectedName)
    })
        .then(response => response.json())
        .then(devices => {

            // Clear current device listings
            var deviceContainer = document.getElementById('deviceContainer');
            deviceContainer.innerHTML = '';
            // Populate with new devices
            for (const device of devices) {
                console.log(device);
                console.log(device.Name);
                var deviceElement = document.createElement('tr');
                deviceElement.innerHTML =
                    `
                        <td>
                            ${device.id}
                        </td>
                        <td>
                            ${device.name}
                        </td>
                        <td>
                            ${device.categoryId}
                        </td>
                        <td>
                            ${device.status}
                        </td>
                        <td>
                            ${device.entryDate}
                        </td>
                        <td>
                            <a href="Device/Edit/${device.id}" class="btn btn-outline-primary" asp-route-id="@item.Id">Edit</a> |
                            <a href="Device/Details/${device.id}" class="btn btn-outline-dark" asp-route-id="@item.Id">Details</a> |
                            <a href="Device/Delete/${device.id}" class="btn btn-outline-danger" asp-route-id="@item.Id">Delete</a>
                        </td>
                `;

                deviceContainer.appendChild(deviceElement);
            }
        })
        .catch(error => console.error('Error:', error));
});
document.getElementById('codeFilter').addEventListener('click', function () {
    var selectedCode = document.getElementById('codeChosen').value;

    fetch('/FilterDevicesByCode', {
        method: 'POST',
        headers: {
            'Content-Type': 'application/json'
        },
        body: JSON.stringify(selectedCode)
    })
        .then(response => response.json())
        .then(devices => {

            // Clear current device listings
            var deviceContainer = document.getElementById('deviceContainer');
            deviceContainer.innerHTML = '';
            // Populate with new devices
            for (const device of devices) {
                console.log(device);
                console.log(device.Name);
                var deviceElement = document.createElement('tr');
                deviceElement.innerHTML =
                    `
                        <td>
                            ${device.id}
                        </td>
                        <td>
                            ${device.name}
                        </td>
                        <td>
                            ${device.categoryId}
                        </td>
                        <td>
                            ${device.status}
                        </td>
                        <td>
                            ${device.entryDate}
                        </td>
                        <td>
                            <a href="Device/Edit/${device.id}" class="btn btn-outline-primary" asp-route-id="@item.Id">Edit</a> |
                            <a href="Device/Details/${device.id}" class="btn btn-outline-dark" asp-route-id="@item.Id">Details</a> |
                            <a href="Device/Delete/${device.id}" class="btn btn-outline-danger" asp-route-id="@item.Id">Delete</a>
                        </td>
                `;

                deviceContainer.appendChild(deviceElement);
            }
        })
        .catch(error => console.error('Error:', error));
});