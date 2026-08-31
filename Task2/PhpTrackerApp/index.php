<?php
declare(strict_types=1);

/**
 * Task 2.4 (High Distinction) demo app for SWE40006 Task 2.
 *
 * Deliberately dependency-free (no Composer, no vendor/) so the Azure App
 * Service Linux/PHP deployment has as few moving parts as possible. Mirrors
 * the .NET TaskTrackerWeb app's Task 2.3 story: DEMO_DISPLAY_TITLE and
 * DEMO_API_KEY are read from configuration (environment variables locally,
 * Azure App Settings in production) rather than hardcoded.
 */

$sessionOk = @session_start();

$displayTitle = getenv('DEMO_DISPLAY_TITLE') ?: "Thuan's PHP Tracker (local dev)";
$apiKey = getenv('DEMO_API_KEY') ?: 'local-dev-key-00000';
$apiKeyPreview = strlen($apiKey) > 8 ? substr($apiKey, 0, 8) . '...' : $apiKey;

if ($sessionOk) {
    $_SESSION['views'] = (int) ($_SESSION['views'] ?? 0) + 1;
    $views = $_SESSION['views'];
} else {
    // Session storage unavailable for some reason - degrade gracefully
    // instead of a fatal error; the page still renders everything else.
    $views = 1;
}

$phpVersion = phpversion();
$serverTimeUtc = (new DateTime('now', new DateTimeZone('UTC')))->format('Y-m-d H:i:s \U\T\C');
$hostname = gethostname() ?: 'unknown';
?>
<!doctype html>
<html lang="en">
<head>
<meta charset="utf-8">
<title><?php echo htmlspecialchars($displayTitle); ?></title>
<meta name="viewport" content="width=device-width, initial-scale=1">
<style>
  :root { color-scheme: light dark; }
  body {
    font-family: -apple-system, BlinkMacSystemFont, "Segoe UI", Roboto, sans-serif;
    max-width: 640px; margin: 3rem auto; padding: 0 1.25rem; line-height: 1.5;
  }
  h1 { margin-bottom: 0.25rem; }
  p.sub { color: #6b7280; margin-top: 0; }
  dl {
    display: grid; grid-template-columns: max-content 1fr; gap: 0.5rem 1.25rem;
    background: rgba(127,127,127,0.10); border-radius: 10px; padding: 1.1rem 1.4rem;
  }
  dt { font-weight: 600; }
  dd { margin: 0; font-family: ui-monospace, SFMono-Regular, Menlo, monospace; }
  footer { margin-top: 2rem; font-size: 0.85rem; color: #6b7280; }
  code { font-family: ui-monospace, SFMono-Regular, Menlo, monospace; }
  a { color: inherit; }
</style>
</head>
<body>
  <h1><?php echo htmlspecialchars($displayTitle); ?></h1>
  <p class="sub">A small PHP 8 demo app for SWE40006 Task 2.4 &mdash; deployed to Azure App Service alongside the ASP.NET Core app.</p>

  <dl>
    <dt>PHP version</dt><dd><?php echo htmlspecialchars($phpVersion); ?></dd>
    <dt>Server time (UTC)</dt><dd><?php echo htmlspecialchars($serverTimeUtc); ?></dd>
    <dt>Host</dt><dd><?php echo htmlspecialchars($hostname); ?></dd>
    <dt>Views this session</dt><dd><?php echo (int) $views; ?></dd>
    <dt>Demo API key (masked)</dt><dd><?php echo htmlspecialchars($apiKeyPreview); ?></dd>
  </dl>

  <footer>
    Loaded from configuration, not hardcoded: <code>DEMO_DISPLAY_TITLE</code> and <code>DEMO_API_KEY</code> come from environment variables &mdash; Azure App Settings in production, same mechanism as the .NET app in Task 2.3. See <a href="health.php">health.php</a> for the JSON health check.
  </footer>
</body>
</html>
