<section>
	<h3>Boka en tid</h3>
	<form method="POST" action="<?=($_SERVER['PHP_SELF'])?>">
		<p>Namn: <input type="text" name="signature" required></p>
		<div>
			<h4>Dagspass</h4>
			<p>
				Spinningcyckel (1-10): 
				<?= $main->generateCycleOptions(true); ?>
			</p>
		</div>
		<div>
			<h4>Kvällspass</h4>
			<p>
				Spinningcyckel (1-10): 
				<?= $main->generateCycleOptions(false); ?>
			</p>
		</div>
		<button type="submit">Boka</button>
	</form>
</section>
