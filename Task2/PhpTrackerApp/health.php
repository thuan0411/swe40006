<?php
declare(strict_types=1);

/**
 * Minimal JSON health/diagnostics endpoint, mirroring the .NET app's
 * /health from Task 2.3 so both apps expose the same kind of check.
 */

header('Content-Type: application/json');

echo json_encode([
    'status' => 'Healthy',
    'phpVersion' => phpversion(),
    'timestampUtc' => (new DateTime('now', new DateTimeZone('UTC')))->format(DateTime::ATOM),
], JSON_PRETTY_PRINT);
